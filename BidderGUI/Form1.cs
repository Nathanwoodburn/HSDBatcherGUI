using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;

namespace BidderGUI
{
    public partial class Form1 : Form
    {
        #region Init

        // Create http client to connect to the api
        HttpClient httpClient = new HttpClient();
        // Create a int to store the time since last batch
        int timetaken = 0;
        // Directory to store settings
        string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\HSDBatcher\\";
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            addlog("For help contact Nathan.Woodburn/ or go to https://l.woodburn.au/discord");
            addlog("If this application helps, please consider supporting me to help pay for costs in developing other projects");
            addlog("https://l.woodburn.au/support");
            UpdateTheme();
            GetSettings();
        }
        #endregion
        #region Start/Stop
        private void stopBatching(object sender, EventArgs e)
        {
            //Stop timers
            countdowntimer.Stop();
            timer1.Stop();

            // Make all fields editable and enabled
            apitextBox.ReadOnly = false;
            wallettextBox.ReadOnly = false;
            passtextBox.ReadOnly = false;
            batchsizenumericud.ReadOnly = false;
            intervalnumericUpDown.ReadOnly = false;
            modecomboBox.Enabled = true;
            bidnumericUpDown.ReadOnly = false;
            blindnumericUpDown.ReadOnly = false;

            // Reset time label
            timelabel.Text = "Time till next batch:";

        }

        private void startBatching(object sender, EventArgs e)
        {
            // Reset timers and start

            timetaken = 0;
            countdowntimer.Start();
            timer1.Interval = (int)intervalnumericUpDown.Value * 1000;
            timer1.Start();

            // Make all fields uneditable
            apitextBox.ReadOnly = true;
            wallettextBox.ReadOnly = true;
            passtextBox.ReadOnly = true;
            batchsizenumericud.ReadOnly = true;
            intervalnumericUpDown.ReadOnly = true;
            modecomboBox.Enabled = false;
            bidnumericUpDown.ReadOnly = true;
            blindnumericUpDown.ReadOnly = true;

            // Run first batch
            sendtransaction();
        }
        #endregion
        #region Timers
        private async void batchTick(object sender, EventArgs e)
        {
            timer1.Interval = (int)intervalnumericUpDown.Value * 1000;
            // reset time since last batch variable
            timetaken = 0;
            // Run send transaction function
            sendtransaction();
        }

        private void countdownTick(object sender, EventArgs e)
        {
            // Add time since last batch
            timetaken += 1;

            // Calculate time to minutes and seconds
            int timeleftsec = (int)intervalnumericUpDown.Value - timetaken;
            TimeSpan time = TimeSpan.FromSeconds(timeleftsec);

            // Update time label
            timelabel.Text = "Time till next batch: " + time.ToString(@"mm\:ss");
        }
        #endregion
        #region API calls
        async void testAPI(object sender, EventArgs e)
        {
            // This will curl the below URL and return the result
            //curl http://x:api-key@127.0.0.1:12039/wallet/$id/account

            addlog("Testing: http://x:" + apitextBox.Text + "@" + ipporttextBox.Text);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "http://" + ipporttextBox.Text + "/wallet/" + wallettextBox.Text + "/account");
            // Add API key to header
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));

            try
            {
                // Send request and log response
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                addlog(responseBody);

            }
            // Log errors to log textbox
            catch (Exception error)
            {
                addlog("Error: " + error.Message);
            }
        }
        async void sendtransaction()
        {
            // Send a batch of transactions

            // Check the selected mode is legit
            string[] modes = { "OPEN", "BID", "REVEAL", "REDEEM", "REGISTER", "RENEW", "UPDATE", "TRANSFER" };

            // If the mode is not in the list
            if (!modes.Contains(modecomboBox.Text))
            {
                addlog("Invalid Mode. Cancelled Sending");
                stopbutton.PerformClick();
            }
            // If there is only 1 domain left in the list
            // Send a single transaction
            if (domainslistBox.Items.Count == 1)
            {
                // Get domain
                string domain = domainslistBox.Items[0].ToString();
                // Log transaction attempt
                addlog("Sending " + modecomboBox.Text + " for: " + domain);


                // Select mode
                if (modecomboBox.Text == "BID")
                {
                    // Create API call
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text + "/wallet/" + wallettextBox.Text + "/bid");
                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                    string curltext = "{\"passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true,\"bid\":" + getbid(true) + ",\"lockup\":" + getblind(true) + "}";
                    request.Content = new StringContent(curltext);

                    // Send request
                    sendapicall(request, domain);

                }
                else if (modecomboBox.Text == "REGISTER")
                {
                    // Use UPDATE for REGISTER

                    // Create API call
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text + "/wallet/" + wallettextBox.Text + "/update");
                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                    string curltext = "{\"passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true,\"data\": {\"records\":[]}}";
                    request.Content = new StringContent(curltext);

                    // Send request
                    sendapicall(request, domain);

                }
                else if (modecomboBox.Text == "TRANSFER")
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text + "/wallet/" + wallettextBox.Text + "/transfer");
                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                    string curltext = "{\"passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true,\"address\":\"" + textBoxAddress.Text + "\"}";
                    request.Content = new StringContent(curltext);
                    sendapicall(request, domain);
                }
                else
                {
                    // Create API call
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text + "/wallet/" + wallettextBox.Text + "/" + modecomboBox.Text.ToLower());
                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                    string curltext = "{\"passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true}";
                    request.Content = new StringContent(curltext);

                    // Send request
                    sendapicall(request, domain);
                }
            }
            // If there is more than 1 domain left in the list
            // Send a batch of transactions
            else if (domainslistBox.Items.Count > 1)
            {
                // Get the top batch of domains
                string[] domains = domainslistBox.Items.OfType<string>().ToArray();
                domains = domains.Take((int)batchsizenumericud.Value).ToArray();

                // Select mode
                if (modecomboBox.Text == "BID")
                {
                    // Send API call
                    sendbatchbid(domains);
                }
                else if (modecomboBox.Text == "REGISTER")
                {
                    // Send API call
                    sendbatchupdate(domains);
                }
                else if (modecomboBox.Text == "UPDATE")
                {
                    // Generate records
                    string records = "";
                    string TXTs = "";
                    foreach (string record in dnslistBox.Items.OfType<string>().ToArray())
                    {
                        if (record.Contains("{")) // Is not a TXT record
                        {
                            records = records + record + ",";
                        }
                        else
                        {
                            TXTs = TXTs + "\"" + record + "\",";
                        }
                    }
                    if (records != "")
                    {
                        records = records.Substring(0, records.Length - 1);
                    }
                    if (TXTs != "")
                    {
                        records = records + ",{\"type\": \"TXT\",\"txt\": [" + TXTs.Substring(0, TXTs.Length - 1) + "]}";
                    }


                    // Send API call
                    sendbatchupdate(domains, records);
                }
                else
                {
                    // Send API call
                    sendbatch(domains, modecomboBox.Text);
                }

            }
            // If there are no domains left in the list
            else
            {
                // Log error
                addlog("No Domains Found. Cancelled Sending");
                // Stop timers
                stopbutton.PerformClick();

            }
        }

        async void sendbatchbid(string[] domains)
        {
            // Create the batch for the API call
            string batch = "[";
            foreach (string domain in domains)
            {
                batch = batch + "[\"BID\", \"" + domain + "\", " + getbid() + ", " + (bidnumericUpDown.Value + blindnumericUpDown.Value).ToString().Replace(",", ".") + "], ";
            }
            // Finish the JSON by removing the last comma and adding a closing bracket
            batch = batch.Substring(0, batch.Length - 2) + "]";
            if (ledgercheckBox.Checked)
            {
                ledger(batch);
                // Remove domains from list
                foreach (string domain in domains)
                {
                    domainslistBox.Items.Remove(domain);
                }
            }
            else
            {
                // Send a batch of bid transactions for domains
                try
                {
                    await unlockwallet();

                    // Create a HTTP request with the API key
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text);
                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));




                    // Log transaction attempt
                    addlog("Sending: " + batch);

                    // Create the API call
                    request.Content = new StringContent("{\"method\": \"sendbatch\",\"params\":[ " + batch + "]}");

                    // Send request
                    HttpResponseMessage response = await httpClient.SendAsync(request);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    addlog(responseBody);
                    response.EnsureSuccessStatusCode();

                    // Log response
                    addlog(responseBody);

                    // Check for errors
                    if (!Checkerrors(responseBody, domains))
                    {
                        // Remove domains from list
                        foreach (string domain in domains)
                        {
                            domainslistBox.Items.Remove(domain);
                        }
                    }


                    // If there are no domains left in the list
                    // Stop timers
                    if (domainslistBox.Items.Count == 0)
                    {
                        addlog("All domains sent");
                        stopbutton.PerformClick();
                    }

                }
                // If there is an error
                catch (Exception ex)
                {
                    // Log error
                    addlog("Error: " + ex.Message);
                    // Stop timers
                    stopbutton.PerformClick();
                }
            }

        }
        async void sendbatch(string[] domains, string method)
        {
            // Create the batch for the API call
            string batch = "[";
            if (modecomboBox.Text == "TRANSFER")
            {
                foreach (string domain in domains)
                {
                    batch = batch + "[\"TRANSFER\", \"" + domain + "\", \""+textBoxAddress.Text+"\"], ";
                }
            }
            else
            {
                foreach (string domain in domains)
                {
                    batch = batch + "[\"" + method + "\", \"" + domain + "\"], ";
                }
            }
            // Finish the JSON by removing the last comma and adding a closing bracket
            batch = batch.Substring(0, batch.Length - 2) + "]";
            if (ledgercheckBox.Checked)
            {
                ledger(batch);
                // Remove domains from list
                foreach (string domain in domains)
                {
                    domainslistBox.Items.Remove(domain);
                }
            }
            else
            {
                // Send a batch of transactions for domains
                try
                {

                    await unlockwallet();

                    // Create a HTTP request with the API key
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text);
                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));



                    // Log transaction attempt
                    addlog("Sending: " + batch);

                    // Create the API call
                    request.Content = new StringContent("{\"method\": \"sendbatch\",\"params\":[ " + batch + "]}");

                    // Send request
                    HttpResponseMessage response = await httpClient.SendAsync(request);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Log response
                    addlog(responseBody);

                    // Remove domains from list
                    if (!Checkerrors(responseBody, domains))
                    {
                        // Remove domains from list
                        foreach (string domain in domains)
                        {
                            domainslistBox.Items.Remove(domain);
                        }
                    }
                    // If there are no domains left in the list
                    // Stop timers
                    if (domainslistBox.Items.Count == 0)
                    {
                        addlog("All domains sent");
                        stopbutton.PerformClick();
                    }


                }
                // If there is an error
                catch (Exception ex)
                {
                    // Log error
                    addlog("Error: " + ex.Message);
                    // Stop timers
                    stopbutton.PerformClick();
                }
            }
        }
        async void sendbatchupdate(string[] domains, string records = "")
        {
            // Create the batch for the API call
            string batch = "[";
            foreach (string domain in domains)
            {
                batch = batch + "[\"UPDATE\", \"" + domain + "\", {\"records\":[" + records + "]}], ";
            }
            // Finish the JSON by removing the last comma and adding a closing bracket
            batch = batch.Substring(0, batch.Length - 2) + "]";
            if (ledgercheckBox.Checked)
            {
                ledger(batch);
                // Remove domains from list
                foreach (string domain in domains)
                {
                    domainslistBox.Items.Remove(domain);
                }
            }
            else
            {
                // Send a batch of transactions for domains
                try
                {

                    await unlockwallet();

                    // Create a HTTP request with the API key
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text);
                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));



                    // Log transaction attempt
                    addlog("Sending: " + batch);

                    // Create the API call
                    request.Content = new StringContent("{\"method\": \"sendbatch\",\"params\":[ " + batch + "]}");

                    // Send request
                    HttpResponseMessage response = await httpClient.SendAsync(request);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Log response
                    addlog(responseBody);

                    // Remove domains from list
                    if (!Checkerrors(responseBody, domains))
                    {
                        // Remove domains from list
                        foreach (string domain in domains)
                        {
                            domainslistBox.Items.Remove(domain);
                        }
                    }
                    // If there are no domains left in the list
                    // Stop timers
                    if (domainslistBox.Items.Count == 0)
                    {
                        addlog("All domains sent");
                        stopbutton.PerformClick();
                    }


                }
                // If there is an error
                catch (Exception ex)
                {
                    // Log error
                    addlog("Error: " + ex.Message);
                    // Stop timers
                    stopbutton.PerformClick();
                }
            }
        }

        async Task unlockwallet()
        {
            // Unlocking wallet
            addlog("Unlocking Wallet using passphrase");
            HttpRequestMessage unlockwalletreq = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text + "/wallet/" + wallettextBox.Text + "/unlock");
            unlockwalletreq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
            unlockwalletreq.Content = new StringContent("{\"passphrase\": \"" + passtextBox.Text + "\",\"timeout\": 60}");

            // Send request
            HttpResponseMessage unlockwalletresp = await httpClient.SendAsync(unlockwalletreq);


            unlockwalletresp.EnsureSuccessStatusCode();

            // Select wallet
            addlog("Selecting Wallet");
            HttpRequestMessage selectwalletreq = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text);
            selectwalletreq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
            selectwalletreq.Content = new StringContent("{\"method\": \"selectwallet\",\"params\":[ \"" + wallettextBox.Text + "\"]}");

            // Send request
            HttpResponseMessage selectwalletresp = await httpClient.SendAsync(selectwalletreq);


            selectwalletresp.EnsureSuccessStatusCode();
        }
        async void sendapicall(HttpRequestMessage request, string domain)
        {
            // Send a single transaction for a domain
            try
            {
                // Send request
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Log response
                addlog(responseBody);
                // Remove domain from list
                string[] domains = { domain };
                if (!Checkerrors(responseBody, domains))
                {
                    // Remove domains from list
                    domainslistBox.Items.Remove(domain);

                }

            }
            // If there is an error
            catch (Exception ex)
            {
                // Log error
                addlog("Error: " + ex.Message);
                // Stop timers
                stopbutton.PerformClick();
            }
        }
        public async void ledger(string batch)
        {
            await unlockwallet();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text);
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));



            // Log transaction attempt
            addlog("Creating batch. . .");
            string content = "{\"method\": \"createbatch\",\"params\":[ " + batch + "]}";
            //addlog(content);
            // Create the API call
            request.Content = new StringContent(content);

            // Send request
            HttpResponseMessage response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            // Log response
            addlog(responseBody);

            addlog("Saved to clipboard.");
            Clipboard.SetText(responseBody);
        }
        #endregion
        #region Networks
        private void mainnetbutton_Click(object sender, EventArgs e)
        {
            // Set the API URL to mainnet
            ipporttextBox.Text = "127.0.0.1:12039";
        }

        private void regtestbutton_Click(object sender, EventArgs e)
        {
            // Set the API URL to regtest
            ipporttextBox.Text = "127.0.0.1:14039";
        }
        #endregion
        #region Logging
        public bool Checkerrors(string log, string[] domains)
        {
            log = log.ToLower();
            // If there is an error in the log
            if (log.Contains("tx exceeds maximum unconfirmed ancestors"))
            {
                if (skiperrorscheck.Checked)
                {

                    timer1.Interval = 600000;

                    //cooldowntimer.Start();
                }
                else
                {
                    stopbutton.PerformClick();
                }
                // Temporarily set the timer to 10 minutes before restending the batch.
                // Log error
                addlog("Errors Found");
                return true;
            }
            else if (log.Contains("error\":{\"message"))
            {
                if (skiperrorscheck.Checked)
                {
                    StreamWriter streamWriter = new StreamWriter(dir + "log.txt", true);
                    foreach (string domain in domains)
                    {
                        domainslistBox.Items.Remove(domain);
                        streamWriter.WriteLine(domain);
                    }
                    streamWriter.Close();
                    streamWriter.Dispose();
                    addlog("Added log at: " + dir + "log.txt");
                }
                else
                {
                    stopbutton.PerformClick();
                }
                // Log error
                addlog("Errors Found");
                return true;

            }
            else
            {
                return false;
            }
        }
        public void addlog(string log)
        {
            // Count lines in log textbox
            string[] lines = logtextBox.Text.Split(Environment.NewLine);
            int numlines = lines.Length;
            int maxlines = Convert.ToInt32(loglinesnumeric.Value) - 1;

            string[] newlines = new string[maxlines];
            if (numlines > maxlines)
            {
                Array.Copy(lines, numlines - maxlines, newlines, 0, maxlines);
            }
            else
            {
                newlines = lines;
            }

            logtextBox.Text = string.Join(Environment.NewLine, newlines) + Environment.NewLine + log;
        }
        private void clearLog(object sender, EventArgs e)
        {
            // Clear log
            logtextBox.Text = "";
        }
        #endregion
        #region Domain List
        private void importDomains(object sender, EventArgs e)
        {
            // Import domains from text file

            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                refreshdomain(open.FileName);
            }
        }

        void refreshdomain(string file)
        {
            // Add try to stop missing file errors
            try
            {
                // Open file for reading
                StreamReader filereader = new StreamReader(file);
                // While more lines to read
                while (!filereader.EndOfStream)
                {
                    // Add domain to list if it isn't already in the list
                    string domain = filereader.ReadLine();
                    if (!domainslistBox.Items.Contains(domain))
                    {
                        domainslistBox.Items.Add(domain);
                    }
                    else
                    {

                        addlog("Domain already in list: " + domain);
                    }
                }
                filereader.Close();
            }
            // Log errors to log textbox
            catch (Exception error)
            {

                addlog("Error: " + error.Message);
            }
            calculatecost();

        }
        private void addDomain(object sender, EventArgs e)
        {
            // If there is a domain in the textbox and it is not already in the list
            if (domaintextBox.Text != "" && !domainslistBox.Items.Contains(domaintextBox.Text))
            {
                // Add the domain to the list
                domainslistBox.Items.Add(domaintextBox.Text);
                domaintextBox.Text = "";
            }
            calculatecost();
        }

        private void removeDomain(object sender, EventArgs e)
        {
            // Remove the selected domain from the list
            try
            {
                domainslistBox.Items.Remove(domainslistBox.SelectedItem.ToString());
                removebutton.Enabled = false;
            }
            catch (Exception ex)
            {
                addlog("Error: " + ex.Message);
            }
            calculatecost();
        }


        private void domainslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If there is a domain selected in the list enable the remove button
            removebutton.Enabled = true;
        }

        private void exportDomains(object sender, EventArgs e)
        {
            // If there are domains in the list
            if (domainslistBox.Items.Count > 0)
            {
                // Create a new save file dialog
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text File|*.txt";

                // If user saves file
                if (save.ShowDialog() == DialogResult.OK)
                {
                    // Write domains to file
                    try
                    {
                        // Create a new file stream
                        StreamWriter writer = new StreamWriter(save.FileName);

                        // For each file in the domain list box
                        foreach (string domain in domainslistBox.Items.OfType<string>().ToArray())
                        {
                            // Write domain to file
                            writer.WriteLine(domain);
                        }
                        // Close the file stream
                        writer.Dispose();
                    }
                    // If there is an error
                    catch (Exception ex)
                    {
                        // Log error
                        addlog("Error: " + ex.Message);
                    }
                }
            }
        }

        private void domaintextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the enter key is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Press the add domain button
                addbutton.PerformClick();
            }
        }
        private void clearDomains(object sender, EventArgs e)
        {
            domainslistBox.Items.Clear();
            calculatecost();
        }

        #endregion
        #region Bid/Blind

        private void bidnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatecost();
        }
        private void blindnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calculatecost();
        }
        public void calculatecost()
        {
            decimal perdomain = (blindnumericUpDown.Value + bidnumericUpDown.Value);
            perbidcostlabel.Text = perdomain.ToString() + " HNS per domain";
            totalcostlabel.Text = (perdomain * domainslistBox.Items.Count).ToString() + " HNS total";
        }
        string getbid(bool convert = false)
        {
            // Convert bid numeric picker to string and replace commas with periods (used to fix local decimal seperator)

            // Allow conversion to dollarydoos needed for some API calls
            if (convert)
            {
                return (bidnumericUpDown.Value * 1000000).ToString().Replace(",", ".");
            }
            else
            {
                return bidnumericUpDown.Value.ToString().Replace(",", ".");
            }
        }
        string getblind(bool convert = false)
        {
            // Convert blind numeric picker to string and replace commas with periods (used to fix local decimal seperator)

            // Allow conversion to dollarydoos needed for some API calls
            if (convert)
            {
                return (blindnumericUpDown.Value * 1000000).ToString().Replace(",", ".");
            }
            else
            {
                return blindnumericUpDown.Value.ToString().Replace(",", ".");
            }
        }
        #endregion
        #region DNS
        private void dnstypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (dnstypecomboBox.Text)
            {
                case "NS":
                    dns1label.Text = "NS:";
                    dns2label.Hide();
                    dns2textBox.Hide();
                    dns3label.Hide();
                    dns3textBox.Hide();
                    dns4label.Hide();
                    dns4textBox.Hide();
                    break;
                case "DS":
                    dns1label.Text = "KeyTag:";
                    dns2label.Text = "Algorithm:";
                    dns2label.Show();
                    dns2textBox.Show();
                    dns3label.Show();
                    dns3textBox.Show();
                    dns4label.Show();
                    dns4textBox.Show();
                    break;
                case "TXT":
                    dns1label.Text = "TXT:";
                    dns2label.Hide();
                    dns2textBox.Hide();
                    dns3label.Hide();
                    dns3textBox.Hide();
                    dns4label.Hide();
                    dns4textBox.Hide();
                    break;
            }
        }

        private void addDNS(object sender, EventArgs e)
        {
            if (dnstypecomboBox.Text == "NS")
            {
                if (validDNS("NS", dns1textBox.Text))
                {
                    if (dns1textBox.Text.Substring(dns1textBox.Text.Length - 1, 1) != ".")
                    {
                        dns1textBox.Text = dns1textBox.Text + ".";
                    }
                    dnslistBox.Items.Add("{\"type\": \"NS\",\"ns\": \"" + dns1textBox.Text + "\"}");
                }
            }
            if (dnstypecomboBox.Text == "DS")
            {
                if (validDNS("DS", dns1textBox.Text, dns2textBox.Text, dns3textBox.Text, dns4textBox.Text))
                {
                    dnslistBox.Items.Add("{\"type\": \"DS\",\"keyTag\": " + dns1textBox.Text + ",\"algorithm\": " + dns2textBox.Text + ",\"digestType\": " + dns3textBox.Text + ",\"digest\": \"" + dns4textBox.Text + "\"}");
                }
            }
            if (dnstypecomboBox.Text == "TXT")
            {
                if (validDNS("TXT", dns1textBox.Text)) // Will mess with later record generation
                {
                    dnslistBox.Items.Add(dns1textBox.Text);
                }
            }
        }
        public bool validDNS(string dnstype, string dns1, string dns2 = "", string dns3 = "", string dns4 = "")
        {

            if (dns1 == "")
            {
                return false;
            }

            if (dnstype == "DS")
            {
                if (dns2 == "" || dns3 == "" || dns4 == "")
                {
                    return false;
                }

                if (!int.TryParse(dns1, out _))
                {
                    addlog("keyTag must be int");
                    return false;
                }
                if (!int.TryParse(dns2, out _))
                {
                    addlog("algorithm must be int");
                    return false;
                }
                if (!int.TryParse(dns3, out _))
                {
                    addlog("digestType must be int");
                    return false;
                }
            }
            if (dnstype == "TXT")
            {
                if (dns1textBox.Text.Contains("{"))
                {
                    addlog("TXT records should not include '{'");
                    return false;
                }

                if (dns1textBox.Text.Contains("'"))
                {
                    addlog("TXT records should not include '");
                    return false;
                }
            }
            return true;
        }

        private void removeDNS(object sender, EventArgs e)
        {
            try
            {
                dnslistBox.Items.Remove(dnslistBox.SelectedItem);
            }
            catch
            {
                addlog("Select record before trying to delete it");
            }
        }

        #endregion
        #region Theming
        private void UpdateTheme()
        {
            // Check if file exists
            if (!Directory.Exists(dir))
            {
                CreateConfig(dir);
            }
            if (!File.Exists(dir + "theme.txt"))
            {
                CreateConfig(dir);
            }

            // Read file
            StreamReader sr = new StreamReader(dir + "theme.txt");
            Dictionary<string, string> theme = new Dictionary<string, string>();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] split = line.Split(':');
                theme.Add(split[0].Trim(), split[1].Trim());
            }
            sr.Dispose();

            if (!theme.ContainsKey("background") || !theme.ContainsKey("background-alt") || !theme.ContainsKey("foreground") || !theme.ContainsKey("foreground-alt"))
            {
                addlog("Theme file is missing key");
                return;
            }

            // Apply theme
            this.BackColor = ColorTranslator.FromHtml(theme["background"]);

            // Foreground
            this.ForeColor = ColorTranslator.FromHtml(theme["foreground"]);
            // Need to specify this for each groupbox to override the black text

            foreach (Control c in this.Controls)
            {
                if (c is GroupBox)
                {
                    c.ForeColor = ColorTranslator.FromHtml(theme["foreground"]);
                    foreach (Control c1 in c.Controls)
                    {
                        if (c1 is TextBox || c1 is ListBox || c1 is NumericUpDown || c1 is Button || c1 is ComboBox)
                        {
                            c1.ForeColor = ColorTranslator.FromHtml(theme["foreground-alt"]);
                            c1.BackColor = ColorTranslator.FromHtml(theme["background-alt"]);
                        }
                    }
                } else if (c is TextBox || c is ListBox || c is NumericUpDown || c is Button || c is ComboBox)
                {
                    c.ForeColor = ColorTranslator.FromHtml(theme["foreground-alt"]);
                    c.BackColor = ColorTranslator.FromHtml(theme["background-alt"]);
                }
            }

            // Transparancy
            applyTransparency(theme);
        }

        private void applyTransparency(Dictionary<string, string> theme)
        {
            if (theme.ContainsKey("transparent-mode"))
            {
                switch (theme["transparent-mode"])
                {
                    case "mica":
                        var accent = new AccentPolicy { AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND };
                        var accentStructSize = Marshal.SizeOf(accent);
                        var accentPtr = Marshal.AllocHGlobal(accentStructSize);
                        Marshal.StructureToPtr(accent, accentPtr, false);
                        var data = new WindowCompositionAttributeData
                        {
                            Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY,
                            SizeOfData = accentStructSize,
                            Data = accentPtr
                        };
                        User32.SetWindowCompositionAttribute(Handle, ref data);
                        Marshal.FreeHGlobal(accentPtr);
                        break;
                    case "key":
                        if (theme.ContainsKey("transparency-key"))
                        {
                            switch (theme["transparency-key"])
                            {
                                case "alt":
                                    this.TransparencyKey = ColorTranslator.FromHtml(theme["background-alt"]);
                                    break;
                                case "main":
                                    this.TransparencyKey = ColorTranslator.FromHtml(theme["background"]);
                                    break;
                                default:
                                    this.TransparencyKey = ColorTranslator.FromHtml(theme["transparency-key"]);
                                    break;
                            }
                        }
                        else
                        {
                            addlog("No transparency-key found in theme file");
                        }
                        break;
                    case "percent":
                        if (theme.ContainsKey("transparency-percent"))
                        {
                            Opacity = Convert.ToDouble(theme["transparency-percent"]) / 100;
                        }
                        else
                        {
                            addlog("No transparency-percent found in theme file");
                        }
                        break;
                }
            }
        }

        private void CreateConfig(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            StreamWriter sw = new StreamWriter(dir + "theme.txt");
            sw.WriteLine("background: #000000");
            sw.WriteLine("foreground: #8e05c2");
            sw.WriteLine("background-alt: #3e065f");
            sw.WriteLine("foreground-alt: #ffffff");
            sw.WriteLine("transparent-mode: off");
            sw.WriteLine("transparency-key: main");
            sw.WriteLine("transparency-percent: 90");

            sw.Dispose();
            addlog("Created theme file");
        }

        // Required for mica effect
        internal enum AccentState
        {
            ACCENT_DISABLED = 0,
            ACCENT_ENABLE_GRADIENT = 1,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_INVALID_STATE = 4
        }

        internal enum WindowCompositionAttribute
        {
            WCA_ACCENT_POLICY = 19
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        internal static class User32
        {
            [DllImport("user32.dll")]
            internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);
        }
        #endregion
        #region Settings
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
        private void GetSettings()
        {
            if (!File.Exists(dir + "settings.txt"))
            {
                return;
            }
            StreamReader sr = new StreamReader(dir + "settings.txt");
            Dictionary<string, string> settings = new Dictionary<string, string>();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (line.Contains(":"))
                {
                    string[] split = line.Split(':');
                    settings.Add(split[0].Trim(), split[1].Trim());
                }
            }
            sr.Close();
            foreach (KeyValuePair<string, string> setting in settings)
            {
                switch (setting.Key)
                {
                    case "api":
                        apitextBox.Text = setting.Value;
                        break;
                    case "ip":
                        ipporttextBox.Text = setting.Value;
                        break;
                    case "wallet":
                        wallettextBox.Text = setting.Value;
                        break;
                    case "pass":
                        passtextBox.Text = setting.Value;
                        break;
                    case "loglines":
                        loglinesnumeric.Value = Convert.ToInt32(setting.Value);
                        break;
                    case "batchsize":
                        batchsizenumericud.Value = Convert.ToInt32(setting.Value);
                        break;
                    case "interval":
                        intervalnumericUpDown.Value = Convert.ToInt32(setting.Value);
                        break;
                    case "mode":
                        modecomboBox.SelectedIndex = Convert.ToInt32(setting.Value);
                        break;
                    case "blind":
                        blindnumericUpDown.Value = Convert.ToDecimal(setting.Value);
                        break;
                    case "bid":
                        bidnumericUpDown.Value = Convert.ToDecimal(setting.Value);
                        break;
                    case "dns":
                        string[] dns = setting.Value.Split('\\');
                        foreach (string domain in dns)
                        {
                            if (domain != "")
                            {
                                dnslistBox.Items.Add(domain.Replace("?", ":"));
                            }
                        }
                        break;
                }
                if (setting.Key.Contains("domain"))
                {
                    if (setting.Value.Trim() != "")
                    {
                        domainslistBox.Items.Add(setting.Value.Trim());
                    }
                }
            }
            addlog("Loaded settings");
        }
        private void SaveSettings()
        {
            addlog("Saving settings");
            // Write settings to file
            StreamWriter sw = new StreamWriter(dir + "settings.txt");
            sw.WriteLine("api: " + apitextBox.Text);
            sw.WriteLine("ip: " + ipporttextBox.Text);
            sw.WriteLine("wallet: " + wallettextBox.Text);
            sw.WriteLine("pass: " + passtextBox.Text);
            sw.WriteLine("loglines: " + loglinesnumeric.Value);
            sw.WriteLine("batchsize: " + batchsizenumericud.Value);
            sw.WriteLine("interval: " + intervalnumericUpDown.Value);
            sw.WriteLine("mode: " + modecomboBox.SelectedIndex);
            sw.WriteLine("blind: " + blindnumericUpDown.Value);
            sw.WriteLine("bid: " + bidnumericUpDown.Value);
            string dns = "";
            foreach (string domain in dnslistBox.Items)
            {
                dns += domain.Replace(":", "?") + "\\";
            }
            sw.WriteLine("dns: " + dns);
            int domaincount = 0;
            foreach (string domain in domainslistBox.Items)
            {
                sw.WriteLine("domain" + domaincount + ": " + domain);
                domaincount++;
            }

            sw.Dispose();
        }
        #endregion

        private void modecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modecomboBox.Text == "TRANSFER")
            {
                groupBoxTransfer.Show();
            }
            else
            {
                groupBoxTransfer.Hide();
            }
        }
    }
}