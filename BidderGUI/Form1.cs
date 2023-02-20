namespace BidderGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Create http client to connect to the api
        HttpClient httpClient = new HttpClient();
        // Create a int to store the time since last batch
        int timetaken = 0;

        private void import_button_Click(object sender, EventArgs e)
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
                        logtextBox.Text += "Domain already in list: " + domain + Environment.NewLine;
                    }
                }
                filereader.Close();
            }
            // Log errors to log textbox
            catch (Exception error)
            {
                logtextBox.Text += "Error: " + error.Message + Environment.NewLine;
                
            }
            

        }
        // Test API
        // Requires API key and wallet name. Password isn't used
        async void test()
        {
            // This will curl the below URL and return the result
            //curl http://x:api-key@127.0.0.1:12039/wallet/$id/account

            logtextBox.Text = logtextBox.Text + "Testing: http://x:" + apitextBox.Text + "@"+ipporttextBox.Text+  Environment.NewLine;
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "http://"+ ipporttextBox.Text + "/wallet/"+wallettextBox.Text+ "/account");
            // Add API key to header
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:"+apitextBox.Text)));
            
            try
            {
                // Send request and log response
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                logtextBox.Text = logtextBox.Text + responseBody + Environment.NewLine;
            }
            // Log errors to log textbox
            catch (Exception error)
            {
                logtextBox.Text = logtextBox.Text + "Error: "+ error.Message+ Environment.NewLine;
            }
        }


        private void test_button_Click(object sender, EventArgs e)
        {
            // Run test on test button click
            test();
        }

        string getbid(bool convert=false)
        {
            if (convert)
            {
                return (bidnumericUpDown.Value * 1000000).ToString().Replace(",",".");
            }
            else
            {
                return bidnumericUpDown.Value.ToString().Replace(",", ".");
            }
        }
        string getblind(bool convert=false)
        {
            if (convert)
            {
                return (blindnumericUpDown.Value * 1000000).ToString().Replace(",", ".");
            }
            else
            {
                return blindnumericUpDown.Value.ToString().Replace(",", ".");
            }
        }
        
        private void clear_button_Click(object sender, EventArgs e)
        {
            // Clear log
            logtextBox.Text = "";
        }

        private void stop_button_Click(object sender, EventArgs e)
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
        
        private void start_button_Click(object sender, EventArgs e)
        {
            // Reset timers and start
            
            timetaken = 0;
            countdowntimer.Start();
            timer1.Interval = (int)intervalnumericUpDown.Value*1000*60;
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

        private async void batch_timer_Tick(object sender, EventArgs e)
        {
            // reset time since last batch variable
            timetaken = 0;
            // Run send transaction function
            sendtransaction();
        }
        async void sendtransaction()
        {
            // Send a batch of transactions
            
            // Check the selected mode is legit
            string[] modes = { "OPEN", "BID", "REVEAL", "REDEEM" };
            if (modes.Contains(modecomboBox.Text))
            {
                // If there is only 1 domain left in the list
                // Send a single transaction
                if (domainslistBox.Items.Count == 1)
                {
                    // Get domain
                    string domain = domainslistBox.Items[0].ToString();
                    // Log transaction attempt
                    logtextBox.Text = logtextBox.Text + "Sending " + modecomboBox.Text + " for: " + domain + Environment.NewLine;

                    // Select mode
                    if (modecomboBox.Text == "BID")
                    {
                        // Create API call
                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://"+ ipporttextBox.Text + "/wallet/" + wallettextBox.Text + "/bid");
                        request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                        string curltext = "{\"passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true,\"bid\":" + getbid(true) + ",\"lockup\":" + getblind(true)+ "}";
                        request.Content = new StringContent(curltext);

                        // Send request
                        sendapicall(request, domain);

                    }
                    else
                    {
                        // Create API call
                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://"+ ipporttextBox.Text + "/wallet/" + wallettextBox.Text + "/" + modecomboBox.Text.ToLower());
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
                    logtextBox.Text = logtextBox.Text + "No Domains Found. Cancelled Sending" + Environment.NewLine;
                    // Stop timers
                    stopbutton.PerformClick();

                }
            }
            // If the selected mode is not legit
            else
            {
                // Log error
                logtextBox.Text = logtextBox.Text + "Invalid Mode. Cancelled Sending" + Environment.NewLine;
                // Stop timers
                stopbutton.PerformClick();
            }
        }
        
        async void sendbatchbid(string[] domains)
        {
            // Send a batch of bid transactions for domains
            try
            {
                await unlockwallet();
                
                // Create a HTTP request with the API key
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://"+ipporttextBox.Text);
                request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));

                // Create the JSON for the API call
                string batch = "[";
                foreach (string domain in domains)
                {
                    batch = batch + "[\"BID\", \"" + domain + "\", " + getbid() + ", " + (bidnumericUpDown.Value + blindnumericUpDown.Value).ToString().Replace(",",".") + "], ";
                }
                // Finish the JSON by removing the last comma and adding a closing bracket
                batch = batch.Substring(0, batch.Length - 2) + "]";

                // Log transaction attempt
                logtextBox.Text = logtextBox.Text + "Sending: " + batch + Environment.NewLine;

                // Create the API call
                request.Content = new StringContent("{\"method\": \"sendbatch\",\"params\":[ " + batch + "]}");

                // Send request
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Log response
                logtextBox.Text = logtextBox.Text + responseBody + Environment.NewLine;

                // Remove domains from list
                foreach (string domain in domains)
                {
                    domainslistBox.Items.Remove(domain);
                }
                // If there are no domains left in the list
                // Stop timers
                if (domainslistBox.Items.Count == 0)
                {
                    logtextBox.Text = logtextBox.Text + "All domains sent" + Environment.NewLine;
                    stopbutton.PerformClick();
                }
            }
            // If there is an error
            catch (Exception ex)
            {
                // Log error
                logtextBox.Text = logtextBox.Text + "Error: " + ex.Message + Environment.NewLine;
                // Stop timers
                stopbutton.PerformClick();
            }
            
        }
        async void sendbatch(string[] domains, string method)
        {
            // Send a batch of transactions for domains
            try
            {

                await unlockwallet();
                
                // Create a HTTP request with the API key
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text);
                request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));

                // Create the JSON for the API call
                string batch = "[";
                foreach (string domain in domains)
                {
                    batch = batch + "[\"" + method + "\", \"" + domain + "\"], ";
                }
                // Finish the JSON by removing the last comma and adding a closing bracket
                batch = batch.Substring(0, batch.Length - 2) + "]";

                // Log transaction attempt
                logtextBox.Text = logtextBox.Text + "Sending: " + batch + Environment.NewLine;

                // Create the API call
                request.Content = new StringContent("{\"method\": \"sendbatch\",\"params\":[ " + batch + "]}");

                // Send request
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Log response
                logtextBox.Text = logtextBox.Text + responseBody + Environment.NewLine;

                // Remove domains from list
                foreach (string domain in domains)
                {
                    domainslistBox.Items.Remove(domain);
                }
                // If there are no domains left in the list
                // Stop timers
                if (domainslistBox.Items.Count == 0)
                {
                    logtextBox.Text = logtextBox.Text + "All domains sent" + Environment.NewLine;
                    stopbutton.PerformClick();
                }
            }
            // If there is an error
            catch (Exception ex)
            {
                // Log error
                logtextBox.Text = logtextBox.Text + "Error: " + ex.Message + Environment.NewLine;
                // Stop timers
                stopbutton.PerformClick();
            }

        }

        async Task unlockwallet()
        {
            // Unlocking wallet
            logtextBox.Text = logtextBox.Text + "Unlocking Wallet using passphrase" + Environment.NewLine;
            HttpRequestMessage unlockwalletreq = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text + "/wallet/" + wallettextBox.Text + "/unlock");
            unlockwalletreq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
            unlockwalletreq.Content = new StringContent("{\"passphrase\": \"" + passtextBox.Text + "\",\"timeout\": 60}");

            // Send request
            HttpResponseMessage unlockwalletresp = await httpClient.SendAsync(unlockwalletreq);


            unlockwalletresp.EnsureSuccessStatusCode();

            // Select wallet
            logtextBox.Text = logtextBox.Text + "Selecting Wallet" + Environment.NewLine;
            HttpRequestMessage selectwalletreq = new HttpRequestMessage(HttpMethod.Post, "http://" + ipporttextBox.Text);
            selectwalletreq.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
            selectwalletreq.Content = new StringContent("{\"method\": \"selectwallet\",\"params\":[ \"" + wallettextBox.Text + "\"]}");

            // Send request
            HttpResponseMessage selectwalletresp = await httpClient.SendAsync(selectwalletreq);


            selectwalletresp.EnsureSuccessStatusCode();
        }
        async void sendapicall(HttpRequestMessage request,string domain)
        {
            // Send a single transaction for a domain
            try
            {
                // Send request
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Log response
                logtextBox.Text = logtextBox.Text + responseBody + Environment.NewLine;

                // Remove domain from list
                domainslistBox.Items.Remove(domain);
            }
            // If there is an error
            catch (Exception ex)
            {
                // Log error
                logtextBox.Text = logtextBox.Text + "Error: " + ex.Message + Environment.NewLine;
                // Stop timers
                stopbutton.PerformClick();
            }
        }

        private void add_domain_button_Click(object sender, EventArgs e)
        {
            // If there is a domain in the textbox and it is not already in the list
            if (domaintextBox.Text != "" && !domainslistBox.Items.Contains(domaintextBox.Text))
            {
                // Add the domain to the list
                domainslistBox.Items.Add(domaintextBox.Text);
                domaintextBox.Text = "";
            }
        }

        private void clear_list_button_Click(object sender, EventArgs e)
        {
            // Clear the domain list
            domainslistBox.Items.Clear();
            removebutton.Enabled = false;
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            // Remove the selected domain from the list
            try
            {
                domainslistBox.Items.Remove(domainslistBox.SelectedItem.ToString());
                removebutton.Enabled = false;
            }
            catch (Exception ex)
            {
                logtextBox.Text = logtextBox.Text + "Error: " + ex.Message + Environment.NewLine;

            }
            
        }

        private void domainslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If there is a domain selected in the list enable the remove button
            removebutton.Enabled = true;
        }

        private void modecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If the mode is set to bid
            if (modecomboBox.Text == "BID")
            {
                // Show the bid and blind bid fields
                biddinggroupBox.Show();
            }
            else
            {
                // Hide the bid and blind bid fields
                biddinggroupBox.Hide();
            }
        }

        private void export_button_Click(object sender, EventArgs e)
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
                        logtextBox.Text = logtextBox.Text + "Error: " + ex.Message + Environment.NewLine;
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

        private void countdowntimer_Tick(object sender, EventArgs e)
        {
            // Add time since last batch
            timetaken += 1;
            
            // Calculate time to minutes and seconds
            int timeleftsec = (int)intervalnumericUpDown.Value * 60 - timetaken;
            TimeSpan time = TimeSpan.FromSeconds(timeleftsec);

            // Update time label
            timelabel.Text = "Time till next batch: " + time.ToString(@"mm\:ss");
        }

        private void mainnetbutton_Click(object sender, EventArgs e)
        {
            // Set the API URL to mainnet
            ipporttextBox.Text ="127.0.0.1:12039";
        }

        private void regtestbutton_Click(object sender, EventArgs e)
        {
            // Set the API URL to regtest
            ipporttextBox.Text = "127.0.0.1:14039";
        }

        private void button_cleardomains_Click(object sender, EventArgs e)
        {
            domainslistBox.Items.Clear();
        }
    }
}