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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)intervalnumericUpDown.Value;
            timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (domainslistBox.Items.Count > 0)
            {


                string domain = domainslistBox.Items[0].ToString();
                domainslistBox.Items.Remove(domain);
                logtextBox.Text = logtextBox.Text + "Sending bid for: " + domain + Environment.NewLine;
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:12039/wallet/" + wallettextBox.Text + "/bid");

                request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes("x:" + apitextBox.Text)));
                logtextBox.Text = logtextBox.Text + "{passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true,\"bid\":" + bidnumericUpDown.Value * 1000000 + ",\"lockup\":" + blindnumericUpDown.Value * 1000000 + "}"+ Environment.NewLine;
                request.Content = new StringContent("{passphrase\":\"" + passtextBox.Text + "\",\"name\":\"" + domain + "\",\"broadcast\":true,\"sign\":true,\"bid\":" + bidnumericUpDown.Value * 1000000 + ",\"lockup\":" + blindnumericUpDown.Value * 1000000 + "}");
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");


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

                }
            }
            else
            {
                timer1.Stop();
                logtextBox.Text = logtextBox.Text + "Sent all bids. Stoping bidding"+ Environment.NewLine;
            }

        }
    }
}