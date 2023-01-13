using System.Xml.Serialization;
using System.IO;
using System.Net.Http;
using System.Security.Policy;
using System.Net.Http.Headers;

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
            open.ShowDialog();
            filetextbox.Text = open.FileName;
            refreshdomain();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshdomain();
        }
        void refreshdomain()
        {
            // Add try to stop missing file errors
            try
            {
                StreamReader filereader = new StreamReader(filetextbox.Text);
                while (!filereader.EndOfStream)
                {
                    domainslistBox.Items.Add(filereader.ReadLine());
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
            timer1.Stop();
            modecomboBox.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //timer1.Interval = (int)intervalnumericUpDown.Value;
            //timer1.Start();
            //modecomboBox.Enabled = false;
            sendtransaction();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            
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
                }
            }
            else
            { 
                logtextBox.Text = logtextBox.Text + "Invalid Mode" + Environment.NewLine;
            }
        }
        async void sendbatchbid(string[] domains,string method)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:12039");
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:"+apitextBox.Text)));

            string batch = "[";
            foreach (string domain in domains)
            {
                batch = batch + "['" + method + "', '" + domain + "', " + bidnumericUpDown.Value + ", " + blindnumericUpDown.Value + "], ";
            }
            batch = batch.Substring(0,batch.Length-2) + "]";
            logtextBox.Text = logtextBox.Text + "Sending: " + batch + Environment.NewLine;

            request.Content = new StringContent("{\"method\": \"sendbatch\",\"params\": [ \""+batch+"\"]}");
            HttpResponseMessage response = await httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            logtextBox.Text = logtextBox.Text + responseBody + Environment.NewLine;
        }
        async void sendbatch(string[] domains, string method)
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
    }
}