using System.Xml.Serialization;
using System.IO;
using System.Net.Http;
using System.Security.Policy;
using System.Net.Http.Headers;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BidderGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                refreshdomain(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        void refreshdomain(string file)
        {
            // Add try to stop missing file errors
            try
            {
                StreamReader filereader = new StreamReader(file);
                while (!filereader.EndOfStream)
                {
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
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
            

        }

        async void test()
        {
            //curl http://x:api-key@127.0.0.1:12039/wallet/$id/account
            logtextBox.Text = logtextBox.Text + "Testing: http://x:" + apitextBox.Text + "@127.0.0.1:12039" + Environment.NewLine;
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "http://127.0.0.1:12039/wallet/"+wallettextBox.Text+ "/account");
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:"+apitextBox.Text)));
            try
            {
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                logtextBox.Text = logtextBox.Text + responseBody + Environment.NewLine;
            }
            catch (Exception error)
            {
                logtextBox.Text = logtextBox.Text + "Error: "+ error.Message+ Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test();
        }

        HttpClient httpClient = new HttpClient();
       
        private void button4_Click(object sender, EventArgs e)
        {
            logtextBox.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Stop sending
            countdowntimer.Stop();
            timer1.Stop();
            apitextBox.ReadOnly = false;
            wallettextBox.ReadOnly = false;
            passtextBox.ReadOnly = false;
            batchsizenumericud.ReadOnly = false;
            intervalnumericUpDown.ReadOnly = false;
            modecomboBox.Enabled = true;
            bidnumericUpDown.ReadOnly = false;
            blindnumericUpDown.ReadOnly = false;
            timelabel.Text = "Time till next batch:";

        }
        int timetaken = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            // start sending
            
            timetaken = 0;
            countdowntimer.Start();
            timer1.Interval = (int)intervalnumericUpDown.Value*1000*60;
            timer1.Start();

            apitextBox.ReadOnly = true;
            wallettextBox.ReadOnly = true;
            passtextBox.ReadOnly = true;
            batchsizenumericud.ReadOnly = true;
            intervalnumericUpDown.ReadOnly = true;
            modecomboBox.Enabled = false;
            bidnumericUpDown.ReadOnly = true;
            blindnumericUpDown.ReadOnly = true;
            
            sendtransaction();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timetaken = 0;
            sendtransaction();
        }
        async void sendtransaction()
        {
            // Check mode is legit
            string[] modes = { "OPEN", "BID", "REVEAL", "REDEEM" };
            if (modes.Contains(modecomboBox.Text))
            {
                if (domainslistBox.Items.Count == 1)
                {
                    string domain = domainslistBox.Items[0].ToString();
                    logtextBox.Text = logtextBox.Text + "Sending " + modecomboBox.Text + " for: " + domain + Environment.NewLine;

                    if (modecomboBox.Text == "BID")
                    {
                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:12039/wallet/" + wallettextBox.Text + "/bid");
                        request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                        string curltext = "{\"passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true,\"bid\":" + bidnumericUpDown.Value * 1000000 + ",\"lockup\":" + blindnumericUpDown.Value * 1000000 + "}";
                        request.Content = new StringContent(curltext);
                        sendapicall(request, domain);

                    }
                    else
                    {
                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:12039/wallet/" + wallettextBox.Text + "/" + modecomboBox.Text.ToLower());
                        request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                        string curltext = "{\"passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true}";
                        request.Content = new StringContent(curltext);
                        sendapicall(request, domain);
                    }
                }
                else if (domainslistBox.Items.Count > 1)
                {

                    string[] domains = domainslistBox.Items.OfType<string>().ToArray();
                    domains = domains.Take((int)batchsizenumericud.Value).ToArray();

                    if (modecomboBox.Text == "BID")
                    {
                        sendbatchbid(domains, modecomboBox.Text);
                    }
                    else
                    {
                        sendbatch(domains, modecomboBox.Text);
                    }
                    
                }
                else
                {
                    logtextBox.Text = logtextBox.Text + "No Domains Found. Cancelled Sending" + Environment.NewLine;
                    stopbutton.PerformClick();

                }
            }
            else
            { 
                logtextBox.Text = logtextBox.Text + "Invalid Mode" + Environment.NewLine;
                stopbutton.PerformClick();
            }
        }
        async void sendbatchbid(string[] domains,string method)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:12039");
                request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));

                string batch = "[";
                foreach (string domain in domains)
                {
                    batch = batch + "['" + method + "', '" + domain + "', " + bidnumericUpDown.Value + ", " + (bidnumericUpDown.Value + blindnumericUpDown.Value) + "], ";
                }
                batch = batch.Substring(0, batch.Length - 2) + "]";
                logtextBox.Text = logtextBox.Text + "Sending: " + batch + Environment.NewLine;

                request.Content = new StringContent("{\"method\": \"sendbatch\",\"params\": [ \"" + batch + "\"]}");
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                logtextBox.Text = logtextBox.Text + responseBody + Environment.NewLine;

                foreach (string domain in domains)
                {
                    domainslistBox.Items.Remove(domain);
                }
                if (domainslistBox.Items.Count == 0)
                {
                    logtextBox.Text = logtextBox.Text + "All domains sent" + Environment.NewLine;
                    stopbutton.PerformClick();
                }
            }
            catch (Exception error)
            {
                logtextBox.Text = logtextBox.Text + "ERROR: " + error.Message + Environment.NewLine;
                stopbutton.PerformClick();
            }
            
        }
        async void sendbatch(string[] domains, string method)
        {
            try
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:12039");
                request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));

                string batch = "[";
                foreach (string domain in domains)
                {
                    batch = batch + "['" + method + "', '" + domain + "'], ";
                }
                batch = batch.Substring(0, batch.Length - 2) + "]";
                logtextBox.Text = logtextBox.Text + "Sending: " + batch + Environment.NewLine;

                request.Content = new StringContent("{\"method\": \"sendbatch\",\"params\": [ \"" + batch + "\"]}");
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                logtextBox.Text = logtextBox.Text + responseBody + Environment.NewLine;
                foreach (string domain in domains)
                {
                    domainslistBox.Items.Remove(domain);
                }
                if (domainslistBox.Items.Count == 0)
                {
                    logtextBox.Text = logtextBox.Text + "All domains sent" + Environment.NewLine;
                    stopbutton.PerformClick();
                }
            }
            catch (Exception error)
            {
                logtextBox.Text = logtextBox.Text + "ERROR: " + error.Message + Environment.NewLine;
                stopbutton.PerformClick();
            }
            
        }

        async void sendapicall(HttpRequestMessage request,string domain)
        {
            try
            {
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                logtextBox.Text = logtextBox.Text + responseBody + Environment.NewLine;
                domainslistBox.Items.Remove(domain);
            }
            catch (Exception error)
            {
                logtextBox.Text = logtextBox.Text + "Error: " + error.Message + Environment.NewLine;
                timer1.Stop();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (domaintextBox.Text != "" && !domainslistBox.Items.Contains(domaintextBox.Text))
            {
                domainslistBox.Items.Add(domaintextBox.Text);
                domaintextBox.Text = "";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            domainslistBox.Items.Clear();
            removebutton.Enabled = false;
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            domainslistBox.Items.Remove(domainslistBox.SelectedItem.ToString());
            removebutton.Enabled = false;
        }

        private void domainslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removebutton.Enabled = true;
        }

        private void modecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modecomboBox.Text == "BID")
            {
                biddinggroupBox.Show();
            }
            else
            {
                biddinggroupBox.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (domainslistBox.Items.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text File|*.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StreamWriter writer = new StreamWriter(save.FileName);
                        foreach (string domain in domainslistBox.Items.OfType<string>().ToArray())
                        {
                            writer.WriteLine(domain);
                        }
                        writer.Dispose();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error: " + error.Message);
                    }
                    
                }
                
            }
        }

        private void domaintextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button2_Click_1(sender, e);
            }
        }

        private void countdowntimer_Tick(object sender, EventArgs e)
        {
            timetaken += 1;
            int timeleftsec = (int)intervalnumericUpDown.Value * 60 - timetaken;
            TimeSpan time = TimeSpan.FromSeconds(timeleftsec);

            timelabel.Text = "Time till next batch: " + time.ToString(@"hh\:mm\:ss");
        }
    }
}