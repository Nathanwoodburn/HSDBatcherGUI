namespace BidderGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            domainslistBox = new ListBox();
            label3 = new Label();
            label4 = new Label();
            bidnumericUpDown = new NumericUpDown();
            blindnumericUpDown = new NumericUpDown();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            apitextBox = new TextBox();
            logtextBox = new TextBox();
            label7 = new Label();
            wallettextBox = new TextBox();
            button4 = new Button();
            label8 = new Label();
            passtextBox = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            startbutton = new Button();
            stopbutton = new Button();
            label9 = new Label();
            intervalnumericUpDown = new NumericUpDown();
            label10 = new Label();
            modecomboBox = new ComboBox();
            label11 = new Label();
            walletgroupBox = new GroupBox();
            groupBox2 = new GroupBox();
            removebutton = new Button();
            buttoncleardomains = new Button();
            addbutton = new Button();
            label1 = new Label();
            domaintextBox = new TextBox();
            button8 = new Button();
            biddinggroupBox = new GroupBox();
            totalcostlabel = new Label();
            perbidcostlabel = new Label();
            label2 = new Label();
            label12 = new Label();
            batchsizenumericud = new NumericUpDown();
            settingsgroupBox = new GroupBox();
            label13 = new Label();
            groupBox3 = new GroupBox();
            skiperrorscheck = new CheckBox();
            loglinesnumeric = new NumericUpDown();
            label15 = new Label();
            timelabel = new Label();
            countdowntimer = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            regtestbutton = new Button();
            mainnetbutton = new Button();
            ipporttextBox = new TextBox();
            label14 = new Label();
            ledgergroupBox = new GroupBox();
            label16 = new Label();
            ledgercheckBox = new CheckBox();
            updategroupBox = new GroupBox();
            dns4textBox = new TextBox();
            dns3textBox = new TextBox();
            dns2textBox = new TextBox();
            dns1textBox = new TextBox();
            dns4label = new Label();
            dns3label = new Label();
            dns2label = new Label();
            dns1label = new Label();
            dnstypecomboBox = new ComboBox();
            label17 = new Label();
            button5 = new Button();
            dnslistBox = new ListBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)bidnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blindnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intervalnumericUpDown).BeginInit();
            walletgroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            biddinggroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)batchsizenumericud).BeginInit();
            settingsgroupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loglinesnumeric).BeginInit();
            groupBox1.SuspendLayout();
            ledgergroupBox.SuspendLayout();
            updategroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(62, 6, 95);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(80, 23);
            button1.TabIndex = 1;
            button1.TabStop = false;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = false;
            button1.Click += import_button_Click;
            // 
            // domainslistBox
            // 
            domainslistBox.BackColor = Color.FromArgb(62, 6, 95);
            domainslistBox.Dock = DockStyle.Right;
            domainslistBox.ForeColor = Color.White;
            domainslistBox.FormattingEnabled = true;
            domainslistBox.ItemHeight = 15;
            domainslistBox.Location = new Point(230, 19);
            domainslistBox.Name = "domainslistBox";
            domainslistBox.Size = new Size(188, 328);
            domainslistBox.TabIndex = 4;
            domainslistBox.TabStop = false;
            domainslistBox.SelectedIndexChanged += domainslistBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 19);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "Bid:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 50);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "Blind:";
            // 
            // bidnumericUpDown
            // 
            bidnumericUpDown.BackColor = Color.FromArgb(62, 6, 95);
            bidnumericUpDown.DecimalPlaces = 3;
            bidnumericUpDown.ForeColor = Color.White;
            bidnumericUpDown.Location = new Point(88, 11);
            bidnumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            bidnumericUpDown.Name = "bidnumericUpDown";
            bidnumericUpDown.Size = new Size(141, 23);
            bidnumericUpDown.TabIndex = 4;
            bidnumericUpDown.ThousandsSeparator = true;
            bidnumericUpDown.ValueChanged += bidnumericUpDown_ValueChanged;
            // 
            // blindnumericUpDown
            // 
            blindnumericUpDown.BackColor = Color.FromArgb(62, 6, 95);
            blindnumericUpDown.DecimalPlaces = 3;
            blindnumericUpDown.ForeColor = Color.White;
            blindnumericUpDown.Location = new Point(88, 48);
            blindnumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            blindnumericUpDown.Name = "blindnumericUpDown";
            blindnumericUpDown.Size = new Size(141, 23);
            blindnumericUpDown.TabIndex = 5;
            blindnumericUpDown.ThousandsSeparator = true;
            blindnumericUpDown.ValueChanged += blindnumericUpDown_ValueChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(62, 6, 95);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(7, 111);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.TabStop = false;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = false;
            button3.Click += test_button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 19);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 10;
            label5.Text = "HNS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 22);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 11;
            label6.Text = "API Key:";
            // 
            // apitextBox
            // 
            apitextBox.BackColor = Color.FromArgb(62, 6, 95);
            apitextBox.ForeColor = Color.White;
            apitextBox.Location = new Point(88, 19);
            apitextBox.Name = "apitextBox";
            apitextBox.Size = new Size(244, 23);
            apitextBox.TabIndex = 0;
            // 
            // logtextBox
            // 
            logtextBox.BackColor = Color.FromArgb(62, 6, 95);
            logtextBox.Dock = DockStyle.Bottom;
            logtextBox.ForeColor = Color.White;
            logtextBox.Location = new Point(3, 54);
            logtextBox.Multiline = true;
            logtextBox.Name = "logtextBox";
            logtextBox.ReadOnly = true;
            logtextBox.ScrollBars = ScrollBars.Vertical;
            logtextBox.Size = new Size(1079, 149);
            logtextBox.TabIndex = 13;
            logtextBox.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 51);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 14;
            label7.Text = "Wallet Name:";
            // 
            // wallettextBox
            // 
            wallettextBox.BackColor = Color.FromArgb(62, 6, 95);
            wallettextBox.ForeColor = Color.White;
            wallettextBox.Location = new Point(88, 48);
            wallettextBox.Name = "wallettextBox";
            wallettextBox.Size = new Size(243, 23);
            wallettextBox.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(62, 6, 95);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(1004, 22);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.TabStop = false;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += clear_button_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 80);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 17;
            label8.Text = "Passphrase:";
            // 
            // passtextBox
            // 
            passtextBox.BackColor = Color.FromArgb(62, 6, 95);
            passtextBox.ForeColor = Color.White;
            passtextBox.Location = new Point(88, 77);
            passtextBox.Name = "passtextBox";
            passtextBox.Size = new Size(243, 23);
            passtextBox.TabIndex = 2;
            passtextBox.UseSystemPasswordChar = true;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += batch_timer_Tick;
            // 
            // startbutton
            // 
            startbutton.BackColor = Color.FromArgb(62, 6, 95);
            startbutton.FlatStyle = FlatStyle.Flat;
            startbutton.ForeColor = Color.White;
            startbutton.Location = new Point(11, 333);
            startbutton.Name = "startbutton";
            startbutton.Size = new Size(90, 23);
            startbutton.TabIndex = 6;
            startbutton.Text = "Start";
            startbutton.UseVisualStyleBackColor = false;
            startbutton.Click += start_button_Click;
            // 
            // stopbutton
            // 
            stopbutton.BackColor = Color.FromArgb(62, 6, 95);
            stopbutton.FlatStyle = FlatStyle.Flat;
            stopbutton.ForeColor = Color.White;
            stopbutton.Location = new Point(107, 333);
            stopbutton.Name = "stopbutton";
            stopbutton.Size = new Size(75, 23);
            stopbutton.TabIndex = 7;
            stopbutton.Text = "Stop";
            stopbutton.UseVisualStyleBackColor = false;
            stopbutton.Click += stop_button_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 48);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 21;
            label9.Text = "Batch Interval:";
            // 
            // intervalnumericUpDown
            // 
            intervalnumericUpDown.BackColor = Color.FromArgb(62, 6, 95);
            intervalnumericUpDown.ForeColor = Color.White;
            intervalnumericUpDown.Location = new Point(88, 46);
            intervalnumericUpDown.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            intervalnumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            intervalnumericUpDown.Name = "intervalnumericUpDown";
            intervalnumericUpDown.Size = new Size(141, 23);
            intervalnumericUpDown.TabIndex = 4;
            intervalnumericUpDown.TabStop = false;
            intervalnumericUpDown.Value = new decimal(new int[] { 600, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(235, 48);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 23;
            label10.Text = "seconds";
            // 
            // modecomboBox
            // 
            modecomboBox.BackColor = Color.FromArgb(62, 6, 95);
            modecomboBox.FlatStyle = FlatStyle.Flat;
            modecomboBox.ForeColor = Color.White;
            modecomboBox.FormattingEnabled = true;
            modecomboBox.Items.AddRange(new object[] { "OPEN", "BID", "REVEAL", "REDEEM", "REGISTER", "UPDATE", "RENEW" });
            modecomboBox.Location = new Point(88, 75);
            modecomboBox.Name = "modecomboBox";
            modecomboBox.Size = new Size(141, 23);
            modecomboBox.TabIndex = 3;
            modecomboBox.Text = "BID";
            modecomboBox.SelectedIndexChanged += modecomboBox_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 78);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 25;
            label11.Text = "Mode:";
            // 
            // walletgroupBox
            // 
            walletgroupBox.BackColor = Color.Transparent;
            walletgroupBox.Controls.Add(wallettextBox);
            walletgroupBox.Controls.Add(button3);
            walletgroupBox.Controls.Add(label6);
            walletgroupBox.Controls.Add(apitextBox);
            walletgroupBox.Controls.Add(label7);
            walletgroupBox.Controls.Add(label8);
            walletgroupBox.Controls.Add(passtextBox);
            walletgroupBox.ForeColor = Color.FromArgb(142, 5, 194);
            walletgroupBox.Location = new Point(11, 12);
            walletgroupBox.Name = "walletgroupBox";
            walletgroupBox.Size = new Size(367, 149);
            walletgroupBox.TabIndex = 0;
            walletgroupBox.TabStop = false;
            walletgroupBox.Text = "Wallet";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(removebutton);
            groupBox2.Controls.Add(buttoncleardomains);
            groupBox2.Controls.Add(addbutton);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(domaintextBox);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(domainslistBox);
            groupBox2.ForeColor = Color.FromArgb(142, 5, 194);
            groupBox2.Location = new Point(675, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 350);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Domains";
            // 
            // removebutton
            // 
            removebutton.BackColor = Color.FromArgb(62, 6, 95);
            removebutton.Enabled = false;
            removebutton.FlatStyle = FlatStyle.Flat;
            removebutton.ForeColor = Color.White;
            removebutton.Location = new Point(114, 292);
            removebutton.Name = "removebutton";
            removebutton.Size = new Size(110, 23);
            removebutton.TabIndex = 9;
            removebutton.TabStop = false;
            removebutton.Text = "Remove Selected";
            removebutton.UseVisualStyleBackColor = false;
            removebutton.Click += removebutton_Click;
            // 
            // buttoncleardomains
            // 
            buttoncleardomains.BackColor = Color.FromArgb(62, 6, 95);
            buttoncleardomains.FlatStyle = FlatStyle.Flat;
            buttoncleardomains.ForeColor = Color.White;
            buttoncleardomains.Location = new Point(114, 321);
            buttoncleardomains.Name = "buttoncleardomains";
            buttoncleardomains.Size = new Size(110, 23);
            buttoncleardomains.TabIndex = 8;
            buttoncleardomains.TabStop = false;
            buttoncleardomains.Text = "Clear All";
            buttoncleardomains.UseVisualStyleBackColor = false;
            buttoncleardomains.Click += button_cleardomains_Click;
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.FromArgb(62, 6, 95);
            addbutton.FlatStyle = FlatStyle.Flat;
            addbutton.ForeColor = Color.White;
            addbutton.Location = new Point(114, 111);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(110, 23);
            addbutton.TabIndex = 7;
            addbutton.TabStop = false;
            addbutton.Text = "Add to list";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += add_domain_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 85);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "Domain:";
            // 
            // domaintextBox
            // 
            domaintextBox.BackColor = Color.FromArgb(62, 6, 95);
            domaintextBox.ForeColor = Color.White;
            domaintextBox.Location = new Point(64, 82);
            domaintextBox.Name = "domaintextBox";
            domaintextBox.Size = new Size(160, 23);
            domaintextBox.TabIndex = 5;
            domaintextBox.TabStop = false;
            domaintextBox.KeyPress += domaintextBox_KeyPress;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(62, 6, 95);
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.White;
            button8.Location = new Point(144, 22);
            button8.Name = "button8";
            button8.Size = new Size(80, 23);
            button8.TabIndex = 1;
            button8.TabStop = false;
            button8.Text = "Export";
            button8.UseVisualStyleBackColor = false;
            button8.Click += export_button_Click;
            // 
            // biddinggroupBox
            // 
            biddinggroupBox.BackColor = Color.Transparent;
            biddinggroupBox.Controls.Add(totalcostlabel);
            biddinggroupBox.Controls.Add(perbidcostlabel);
            biddinggroupBox.Controls.Add(bidnumericUpDown);
            biddinggroupBox.Controls.Add(label3);
            biddinggroupBox.Controls.Add(label4);
            biddinggroupBox.Controls.Add(blindnumericUpDown);
            biddinggroupBox.Controls.Add(label2);
            biddinggroupBox.Controls.Add(label5);
            biddinggroupBox.ForeColor = Color.FromArgb(142, 5, 194);
            biddinggroupBox.Location = new Point(11, 368);
            biddinggroupBox.Name = "biddinggroupBox";
            biddinggroupBox.Size = new Size(367, 197);
            biddinggroupBox.TabIndex = 4;
            biddinggroupBox.TabStop = false;
            biddinggroupBox.Text = "Bidding";
            // 
            // totalcostlabel
            // 
            totalcostlabel.AutoSize = true;
            totalcostlabel.Location = new Point(7, 106);
            totalcostlabel.Name = "totalcostlabel";
            totalcostlabel.Size = new Size(67, 15);
            totalcostlabel.TabIndex = 12;
            totalcostlabel.Text = "0 HNS total";
            // 
            // perbidcostlabel
            // 
            perbidcostlabel.AutoSize = true;
            perbidcostlabel.Location = new Point(7, 85);
            perbidcostlabel.Name = "perbidcostlabel";
            perbidcostlabel.Size = new Size(104, 15);
            perbidcostlabel.TabIndex = 11;
            perbidcostlabel.Text = "0 HNS per domain";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 50);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 10;
            label2.Text = "HNS";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 25);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 29;
            label12.Text = "Batch Size:";
            // 
            // batchsizenumericud
            // 
            batchsizenumericud.BackColor = Color.FromArgb(62, 6, 95);
            batchsizenumericud.ForeColor = Color.White;
            batchsizenumericud.Location = new Point(88, 17);
            batchsizenumericud.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            batchsizenumericud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            batchsizenumericud.Name = "batchsizenumericud";
            batchsizenumericud.Size = new Size(141, 23);
            batchsizenumericud.TabIndex = 3;
            batchsizenumericud.TabStop = false;
            batchsizenumericud.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // settingsgroupBox
            // 
            settingsgroupBox.BackColor = Color.Transparent;
            settingsgroupBox.Controls.Add(label13);
            settingsgroupBox.Controls.Add(intervalnumericUpDown);
            settingsgroupBox.Controls.Add(batchsizenumericud);
            settingsgroupBox.Controls.Add(label9);
            settingsgroupBox.Controls.Add(label12);
            settingsgroupBox.Controls.Add(label10);
            settingsgroupBox.Controls.Add(modecomboBox);
            settingsgroupBox.Controls.Add(label11);
            settingsgroupBox.ForeColor = Color.FromArgb(142, 5, 194);
            settingsgroupBox.Location = new Point(11, 167);
            settingsgroupBox.Name = "settingsgroupBox";
            settingsgroupBox.Size = new Size(367, 106);
            settingsgroupBox.TabIndex = 3;
            settingsgroupBox.TabStop = false;
            settingsgroupBox.Text = "Settings";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(235, 19);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 31;
            label13.Text = "domains";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(skiperrorscheck);
            groupBox3.Controls.Add(loglinesnumeric);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(logtextBox);
            groupBox3.Controls.Add(button4);
            groupBox3.ForeColor = Color.FromArgb(142, 5, 194);
            groupBox3.Location = new Point(12, 571);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1085, 206);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Logs";
            // 
            // skiperrorscheck
            // 
            skiperrorscheck.AutoSize = true;
            skiperrorscheck.Location = new Point(10, 22);
            skiperrorscheck.Name = "skiperrorscheck";
            skiperrorscheck.Size = new Size(230, 19);
            skiperrorscheck.TabIndex = 19;
            skiperrorscheck.Text = "Skip Errors (will log them to /errors.txt)";
            skiperrorscheck.UseVisualStyleBackColor = true;
            // 
            // loglinesnumeric
            // 
            loglinesnumeric.BackColor = Color.FromArgb(62, 6, 95);
            loglinesnumeric.ForeColor = Color.White;
            loglinesnumeric.Location = new Point(878, 22);
            loglinesnumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            loglinesnumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            loglinesnumeric.Name = "loglinesnumeric";
            loglinesnumeric.Size = new Size(120, 23);
            loglinesnumeric.TabIndex = 18;
            loglinesnumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(808, 26);
            label15.Name = "label15";
            label15.Size = new Size(70, 15);
            label15.TabIndex = 17;
            label15.Text = "Log Length:";
            // 
            // timelabel
            // 
            timelabel.AutoSize = true;
            timelabel.Location = new Point(188, 337);
            timelabel.Name = "timelabel";
            timelabel.Size = new Size(111, 15);
            timelabel.TabIndex = 33;
            timelabel.Text = "Time till next batch:";
            // 
            // countdowntimer
            // 
            countdowntimer.Interval = 1000;
            countdowntimer.Tick += countdowntimer_Tick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(regtestbutton);
            groupBox1.Controls.Add(mainnetbutton);
            groupBox1.Controls.Add(ipporttextBox);
            groupBox1.Controls.Add(label14);
            groupBox1.ForeColor = Color.FromArgb(142, 5, 194);
            groupBox1.Location = new Point(384, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 149);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Network";
            // 
            // regtestbutton
            // 
            regtestbutton.BackColor = Color.FromArgb(62, 6, 95);
            regtestbutton.FlatStyle = FlatStyle.Flat;
            regtestbutton.ForeColor = Color.White;
            regtestbutton.Location = new Point(87, 111);
            regtestbutton.Name = "regtestbutton";
            regtestbutton.Size = new Size(75, 23);
            regtestbutton.TabIndex = 2;
            regtestbutton.Text = "Regtest";
            regtestbutton.UseVisualStyleBackColor = false;
            regtestbutton.Click += regtestbutton_Click;
            // 
            // mainnetbutton
            // 
            mainnetbutton.BackColor = Color.FromArgb(62, 6, 95);
            mainnetbutton.FlatStyle = FlatStyle.Flat;
            mainnetbutton.ForeColor = Color.White;
            mainnetbutton.Location = new Point(6, 111);
            mainnetbutton.Name = "mainnetbutton";
            mainnetbutton.Size = new Size(75, 23);
            mainnetbutton.TabIndex = 2;
            mainnetbutton.Text = "Mainnet";
            mainnetbutton.UseVisualStyleBackColor = false;
            mainnetbutton.Click += mainnetbutton_Click;
            // 
            // ipporttextBox
            // 
            ipporttextBox.BackColor = Color.FromArgb(62, 6, 95);
            ipporttextBox.ForeColor = Color.White;
            ipporttextBox.Location = new Point(57, 14);
            ipporttextBox.Name = "ipporttextBox";
            ipporttextBox.Size = new Size(222, 23);
            ipporttextBox.TabIndex = 1;
            ipporttextBox.Text = "127.0.0.1:12039";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 19);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 0;
            label14.Text = "IP:PORT";
            // 
            // ledgergroupBox
            // 
            ledgergroupBox.BackColor = Color.Transparent;
            ledgergroupBox.Controls.Add(label16);
            ledgergroupBox.Controls.Add(ledgercheckBox);
            ledgergroupBox.ForeColor = Color.FromArgb(142, 5, 194);
            ledgergroupBox.Location = new Point(384, 167);
            ledgergroupBox.Name = "ledgergroupBox";
            ledgergroupBox.Size = new Size(285, 195);
            ledgergroupBox.TabIndex = 35;
            ledgergroupBox.TabStop = false;
            ledgergroupBox.Text = "Ledger Settings";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 43);
            label16.Name = "label16";
            label16.Size = new Size(196, 120);
            label16.TabIndex = 1;
            label16.Text = resources.GetString("label16.Text");
            // 
            // ledgercheckBox
            // 
            ledgercheckBox.AutoSize = true;
            ledgercheckBox.Location = new Point(5, 21);
            ledgercheckBox.Name = "ledgercheckBox";
            ledgercheckBox.Size = new Size(84, 19);
            ledgercheckBox.TabIndex = 0;
            ledgercheckBox.Text = "Use Ledger";
            ledgercheckBox.UseVisualStyleBackColor = true;
            // 
            // updategroupBox
            // 
            updategroupBox.BackColor = Color.Transparent;
            updategroupBox.Controls.Add(dns4textBox);
            updategroupBox.Controls.Add(dns3textBox);
            updategroupBox.Controls.Add(dns2textBox);
            updategroupBox.Controls.Add(dns1textBox);
            updategroupBox.Controls.Add(dns4label);
            updategroupBox.Controls.Add(dns3label);
            updategroupBox.Controls.Add(dns2label);
            updategroupBox.Controls.Add(dns1label);
            updategroupBox.Controls.Add(dnstypecomboBox);
            updategroupBox.Controls.Add(label17);
            updategroupBox.Controls.Add(button5);
            updategroupBox.Controls.Add(dnslistBox);
            updategroupBox.Controls.Add(button2);
            updategroupBox.ForeColor = Color.FromArgb(142, 5, 194);
            updategroupBox.Location = new Point(384, 368);
            updategroupBox.Name = "updategroupBox";
            updategroupBox.Size = new Size(712, 197);
            updategroupBox.TabIndex = 36;
            updategroupBox.TabStop = false;
            updategroupBox.Text = "DNS Records";
            // 
            // dns4textBox
            // 
            dns4textBox.BackColor = Color.FromArgb(62, 6, 95);
            dns4textBox.ForeColor = Color.White;
            dns4textBox.Location = new Point(87, 135);
            dns4textBox.Name = "dns4textBox";
            dns4textBox.Size = new Size(276, 23);
            dns4textBox.TabIndex = 46;
            dns4textBox.Visible = false;
            // 
            // dns3textBox
            // 
            dns3textBox.BackColor = Color.FromArgb(62, 6, 95);
            dns3textBox.ForeColor = Color.White;
            dns3textBox.Location = new Point(87, 106);
            dns3textBox.Name = "dns3textBox";
            dns3textBox.Size = new Size(276, 23);
            dns3textBox.TabIndex = 46;
            dns3textBox.Visible = false;
            // 
            // dns2textBox
            // 
            dns2textBox.BackColor = Color.FromArgb(62, 6, 95);
            dns2textBox.ForeColor = Color.White;
            dns2textBox.Location = new Point(87, 77);
            dns2textBox.Name = "dns2textBox";
            dns2textBox.Size = new Size(276, 23);
            dns2textBox.TabIndex = 46;
            dns2textBox.Visible = false;
            // 
            // dns1textBox
            // 
            dns1textBox.BackColor = Color.FromArgb(62, 6, 95);
            dns1textBox.ForeColor = Color.White;
            dns1textBox.Location = new Point(87, 48);
            dns1textBox.Name = "dns1textBox";
            dns1textBox.Size = new Size(276, 23);
            dns1textBox.TabIndex = 46;
            // 
            // dns4label
            // 
            dns4label.AutoSize = true;
            dns4label.Location = new Point(15, 138);
            dns4label.Name = "dns4label";
            dns4label.Size = new Size(43, 15);
            dns4label.TabIndex = 45;
            dns4label.Text = "Digest:";
            dns4label.Visible = false;
            // 
            // dns3label
            // 
            dns3label.AutoSize = true;
            dns3label.Location = new Point(15, 109);
            dns3label.Name = "dns3label";
            dns3label.Size = new Size(67, 15);
            dns3label.TabIndex = 44;
            dns3label.Text = "DigestType:";
            dns3label.Visible = false;
            // 
            // dns2label
            // 
            dns2label.AutoSize = true;
            dns2label.Location = new Point(15, 80);
            dns2label.Name = "dns2label";
            dns2label.Size = new Size(64, 15);
            dns2label.TabIndex = 43;
            dns2label.Text = "Algorithm:";
            dns2label.Visible = false;
            // 
            // dns1label
            // 
            dns1label.AutoSize = true;
            dns1label.Location = new Point(15, 51);
            dns1label.Name = "dns1label";
            dns1label.Size = new Size(25, 15);
            dns1label.TabIndex = 42;
            dns1label.Text = "NS:";
            // 
            // dnstypecomboBox
            // 
            dnstypecomboBox.BackColor = Color.FromArgb(62, 6, 95);
            dnstypecomboBox.FlatStyle = FlatStyle.Flat;
            dnstypecomboBox.ForeColor = Color.White;
            dnstypecomboBox.FormattingEnabled = true;
            dnstypecomboBox.Items.AddRange(new object[] { "NS", "DS", "TXT" });
            dnstypecomboBox.Location = new Point(87, 16);
            dnstypecomboBox.Name = "dnstypecomboBox";
            dnstypecomboBox.Size = new Size(130, 23);
            dnstypecomboBox.TabIndex = 41;
            dnstypecomboBox.Text = "NS";
            dnstypecomboBox.SelectedIndexChanged += dnstypecomboBox_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 19);
            label17.Name = "label17";
            label17.Size = new Size(34, 15);
            label17.TabIndex = 40;
            label17.Text = "Type:";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(62, 6, 95);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(391, 168);
            button5.Name = "button5";
            button5.Size = new Size(99, 23);
            button5.TabIndex = 39;
            button5.Text = "Delete Record";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dnslistBox
            // 
            dnslistBox.BackColor = Color.FromArgb(62, 6, 95);
            dnslistBox.Dock = DockStyle.Right;
            dnslistBox.ForeColor = Color.White;
            dnslistBox.FormattingEnabled = true;
            dnslistBox.ItemHeight = 15;
            dnslistBox.Location = new Point(496, 19);
            dnslistBox.Name = "dnslistBox";
            dnslistBox.Size = new Size(213, 175);
            dnslistBox.TabIndex = 38;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(62, 6, 95);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(391, 139);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 37;
            button2.Text = "Add record";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1108, 789);
            Controls.Add(updategroupBox);
            Controls.Add(ledgergroupBox);
            Controls.Add(groupBox1);
            Controls.Add(timelabel);
            Controls.Add(groupBox3);
            Controls.Add(settingsgroupBox);
            Controls.Add(biddinggroupBox);
            Controls.Add(walletgroupBox);
            Controls.Add(stopbutton);
            Controls.Add(startbutton);
            Controls.Add(groupBox2);
            ForeColor = Color.FromArgb(142, 5, 194);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "HSD Batcher GUI";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bidnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)blindnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)intervalnumericUpDown).EndInit();
            walletgroupBox.ResumeLayout(false);
            walletgroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            biddinggroupBox.ResumeLayout(false);
            biddinggroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)batchsizenumericud).EndInit();
            settingsgroupBox.ResumeLayout(false);
            settingsgroupBox.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loglinesnumeric).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ledgergroupBox.ResumeLayout(false);
            ledgergroupBox.PerformLayout();
            updategroupBox.ResumeLayout(false);
            updategroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListBox domainslistBox;
        private Label label3;
        private Label label4;
        private NumericUpDown bidnumericUpDown;
        private NumericUpDown blindnumericUpDown;
        private Button button3;
        private Label label5;
        private Label label6;
        private TextBox apitextBox;
        private TextBox logtextBox;
        private Label label7;
        private TextBox wallettextBox;
        private Button button4;
        private Label label8;
        private TextBox passtextBox;
        private System.Windows.Forms.Timer timer1;
        private Button startbutton;
        private Button stopbutton;
        private Label label9;
        private NumericUpDown intervalnumericUpDown;
        private Label label10;
        private ComboBox modecomboBox;
        private Label label11;
        private GroupBox walletgroupBox;
        private GroupBox groupBox2;
        private Button addbutton;
        private Label label1;
        private TextBox domaintextBox;
        private Button buttoncleardomains;
        private Button removebutton;
        private GroupBox biddinggroupBox;
        private Label label2;
        private Label label12;
        private NumericUpDown batchsizenumericud;
        private GroupBox settingsgroupBox;
        private Label label13;
        private GroupBox groupBox3;
        private Button button8;
        private Label timelabel;
        private System.Windows.Forms.Timer countdowntimer;
        private GroupBox groupBox1;
        private TextBox ipporttextBox;
        private Label label14;
        private Button regtestbutton;
        private Button mainnetbutton;
        private NumericUpDown loglinesnumeric;
        private Label label15;
        private CheckBox skiperrorscheck;
        private GroupBox ledgergroupBox;
        private CheckBox ledgercheckBox;
        private Label label16;
        private GroupBox updategroupBox;
        private Button button2;
        private TextBox dns1textBox;
        private Label dns4label;
        private Label dns3label;
        private Label dns2label;
        private Label dns1label;
        private ComboBox dnstypecomboBox;
        private Label label17;
        private Button button5;
        private ListBox dnslistBox;
        private TextBox dns4textBox;
        private TextBox dns3textBox;
        private TextBox dns2textBox;
        private Label totalcostlabel;
        private Label perbidcostlabel;
    }
}