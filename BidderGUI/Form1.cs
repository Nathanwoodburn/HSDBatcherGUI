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
            timer1.Interval = (int)intervalnumericUpDown.Value;
            timer1.Start();
            modecomboBox.Enabled = false;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (domainslistBox.Items.Count > 0)
            {
                string domain = domainslistBox.Items[0].ToString();
                domainslistBox.Items.Remove(domain);
                logtextBox.Text = logtextBox.Text + "Sending "+ modecomboBox.Text + " for: " + domain + Environment.NewLine;

                if (modecomboBox.Text == "OPEN")
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:12039/wallet/" + wallettextBox.Text + "/open");
                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                    string curltext = "{\"passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true}";
                    request.Content = new StringContent(curltext);
                    sendapicall(request);
                }
                else if (modecomboBox.Text == "BID")
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:12039/wallet/" + wallettextBox.Text + "/bid");
                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                    string curltext = "{\"passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true,\"bid\":" + bidnumericUpDown.Value * 1000000 + ",\"lockup\":" + blindnumericUpDown.Value * 1000000 + "}";
                    request.Content = new StringContent(curltext);
                    sendapicall(request);
                }
                else if (modecomboBox.Text == "REVEAL")
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:12039/wallet/" + wallettextBox.Text + "/reveal");
                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                    string curltext = "{\"passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true}";
                    request.Content = new StringContent(curltext);
                    sendapicall(request);
                }
                else if (modecomboBox.Text == "REDEEM")
                {
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:12039/wallet/" + wallettextBox.Text + "/redeem");
                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                    string curltext = "{\"passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true}";
                    request.Content = new StringContent(curltext);
                    sendapicall(request);
                }
                else
                {
                    timer1.Stop();
                    modecomboBox.Enabled = true;
                    logtextBox.Text = logtextBox.Text + "Invalid Mode" + Environment.NewLine;
                    return;
                }
                


                
            }
            else
            {
                timer1.Stop();
                modecomboBox.Enabled = true;
                logtextBox.Text = logtextBox.Text + "Sent all domains. Stopped sending transactions" + Environment.NewLine;
            }

        }
        async void sendapicall(HttpRequestMessage request)
        {
            try
            {
                HttpResponseMessage response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                logtextBox.Text = logtextBox.Text + responseBody + Environment.NewLine;
            }
            catch (Exception error)
            {
                logtextBox.Text = logtextBox.Text + "Error: " + error.Message + Environment.NewLine;
                timer1.Stop();
            }
        }
    }
}