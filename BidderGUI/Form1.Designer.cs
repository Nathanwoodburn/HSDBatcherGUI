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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.FlatStyle = FlatStyle.Flat;
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
            domainslistBox.BackColor = SystemColors.ControlDarkDark;
            domainslistBox.Dock = DockStyle.Right;
            domainslistBox.ForeColor = Color.White;
            domainslistBox.FormattingEnabled = true;
            domainslistBox.ItemHeight = 15;
            domainslistBox.Location = new Point(230, 19);
            domainslistBox.Name = "domainslistBox";
            domainslistBox.Size = new Size(188, 334);
            domainslistBox.TabIndex = 4;
            domainslistBox.TabStop = false;
            domainslistBox.SelectedIndexChanged += domainslistBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "Bid:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 50);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "Blind:";
            // 
            // bidnumericUpDown
            // 
            bidnumericUpDown.BackColor = SystemColors.ControlDarkDark;
            bidnumericUpDown.DecimalPlaces = 3;
            bidnumericUpDown.ForeColor = Color.White;
            bidnumericUpDown.Location = new Point(88, 11);
            bidnumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            bidnumericUpDown.Name = "bidnumericUpDown";
            bidnumericUpDown.Size = new Size(141, 23);
            bidnumericUpDown.TabIndex = 4;
            bidnumericUpDown.ThousandsSeparator = true;
            // 
            // blindnumericUpDown
            // 
            blindnumericUpDown.BackColor = SystemColors.ControlDarkDark;
            blindnumericUpDown.DecimalPlaces = 3;
            blindnumericUpDown.ForeColor = Color.White;
            blindnumericUpDown.Location = new Point(88, 48);
            blindnumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            blindnumericUpDown.Name = "blindnumericUpDown";
            blindnumericUpDown.Size = new Size(141, 23);
            blindnumericUpDown.TabIndex = 5;
            blindnumericUpDown.ThousandsSeparator = true;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDarkDark;
            button3.FlatStyle = FlatStyle.Flat;
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
            label6.Location = new Point(4, 22);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 11;
            label6.Text = "API Key:";
            // 
            // apitextBox
            // 
            apitextBox.BackColor = SystemColors.ControlDarkDark;
            apitextBox.ForeColor = Color.White;
            apitextBox.Location = new Point(88, 19);
            apitextBox.Name = "apitextBox";
            apitextBox.Size = new Size(244, 23);
            apitextBox.TabIndex = 0;
            // 
            // logtextBox
            // 
            logtextBox.BackColor = SystemColors.ControlDarkDark;
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
            label7.Location = new Point(4, 51);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 14;
            label7.Text = "Wallet Name:";
            // 
            // wallettextBox
            // 
            wallettextBox.BackColor = SystemColors.ControlDarkDark;
            wallettextBox.ForeColor = Color.White;
            wallettextBox.Location = new Point(88, 48);
            wallettextBox.Name = "wallettextBox";
            wallettextBox.Size = new Size(243, 23);
            wallettextBox.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDarkDark;
            button4.FlatStyle = FlatStyle.Flat;
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
            label8.Location = new Point(4, 80);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 17;
            label8.Text = "Passphrase:";
            // 
            // passtextBox
            // 
            passtextBox.BackColor = SystemColors.ControlDarkDark;
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
            startbutton.BackColor = SystemColors.ControlDarkDark;
            startbutton.FlatStyle = FlatStyle.Flat;
            startbutton.Location = new Point(11, 370);
            startbutton.Name = "startbutton";
            startbutton.Size = new Size(90, 23);
            startbutton.TabIndex = 6;
            startbutton.Text = "Start";
            startbutton.UseVisualStyleBackColor = false;
            startbutton.Click += start_button_Click;
            // 
            // stopbutton
            // 
            stopbutton.BackColor = SystemColors.ControlDarkDark;
            stopbutton.FlatStyle = FlatStyle.Flat;
            stopbutton.Location = new Point(107, 370);
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
            label9.Location = new Point(4, 48);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 21;
            label9.Text = "Batch Interval:";
            // 
            // intervalnumericUpDown
            // 
            intervalnumericUpDown.BackColor = SystemColors.ControlDarkDark;
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
            modecomboBox.BackColor = SystemColors.ControlDarkDark;
            modecomboBox.FlatStyle = FlatStyle.Flat;
            modecomboBox.ForeColor = Color.White;
            modecomboBox.FormattingEnabled = true;
            modecomboBox.Items.AddRange(new object[] { "OPEN", "BID", "REVEAL", "REDEEM", "RENEW" });
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
            label11.Location = new Point(7, 78);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 25;
            label11.Text = "Mode:";
            // 
            // walletgroupBox
            // 
            walletgroupBox.BackColor = Color.Black;
            walletgroupBox.Controls.Add(wallettextBox);
            walletgroupBox.Controls.Add(button3);
            walletgroupBox.Controls.Add(label6);
            walletgroupBox.Controls.Add(apitextBox);
            walletgroupBox.Controls.Add(label7);
            walletgroupBox.Controls.Add(label8);
            walletgroupBox.Controls.Add(passtextBox);
            walletgroupBox.ForeColor = Color.White;
            walletgroupBox.Location = new Point(11, 12);
            walletgroupBox.Name = "walletgroupBox";
            walletgroupBox.Size = new Size(367, 149);
            walletgroupBox.TabIndex = 0;
            walletgroupBox.TabStop = false;
            walletgroupBox.Text = "Wallet";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Black;
            groupBox2.Controls.Add(removebutton);
            groupBox2.Controls.Add(buttoncleardomains);
            groupBox2.Controls.Add(addbutton);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(domaintextBox);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(domainslistBox);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(675, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 356);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Domains";
            // 
            // removebutton
            // 
            removebutton.BackColor = SystemColors.ControlDarkDark;
            removebutton.Enabled = false;
            removebutton.FlatStyle = FlatStyle.Flat;
            removebutton.Location = new Point(114, 298);
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
            buttoncleardomains.BackColor = SystemColors.ControlDarkDark;
            buttoncleardomains.FlatStyle = FlatStyle.Flat;
            buttoncleardomains.Location = new Point(114, 327);
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
            addbutton.BackColor = SystemColors.ControlDarkDark;
            addbutton.FlatStyle = FlatStyle.Flat;
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
            label1.Location = new Point(6, 85);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "Domain:";
            // 
            // domaintextBox
            // 
            domaintextBox.BackColor = SystemColors.ControlDarkDark;
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
            button8.BackColor = SystemColors.ControlDarkDark;
            button8.FlatStyle = FlatStyle.Flat;
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
            biddinggroupBox.BackColor = Color.Black;
            biddinggroupBox.Controls.Add(bidnumericUpDown);
            biddinggroupBox.Controls.Add(label3);
            biddinggroupBox.Controls.Add(label4);
            biddinggroupBox.Controls.Add(blindnumericUpDown);
            biddinggroupBox.Controls.Add(label2);
            biddinggroupBox.Controls.Add(label5);
            biddinggroupBox.ForeColor = Color.White;
            biddinggroupBox.Location = new Point(11, 279);
            biddinggroupBox.Name = "biddinggroupBox";
            biddinggroupBox.Size = new Size(367, 85);
            biddinggroupBox.TabIndex = 4;
            biddinggroupBox.TabStop = false;
            biddinggroupBox.Text = "Bidding";
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
            label12.Location = new Point(4, 19);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 29;
            label12.Text = "Batch Size:";
            // 
            // batchsizenumericud
            // 
            batchsizenumericud.BackColor = SystemColors.ControlDarkDark;
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
            settingsgroupBox.BackColor = Color.Black;
            settingsgroupBox.Controls.Add(label13);
            settingsgroupBox.Controls.Add(intervalnumericUpDown);
            settingsgroupBox.Controls.Add(batchsizenumericud);
            settingsgroupBox.Controls.Add(label9);
            settingsgroupBox.Controls.Add(label12);
            settingsgroupBox.Controls.Add(label10);
            settingsgroupBox.Controls.Add(modecomboBox);
            settingsgroupBox.Controls.Add(label11);
            settingsgroupBox.ForeColor = Color.White;
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
            groupBox3.BackColor = Color.Black;
            groupBox3.Controls.Add(skiperrorscheck);
            groupBox3.Controls.Add(loglinesnumeric);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(logtextBox);
            groupBox3.Controls.Add(button4);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(11, 412);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1085, 206);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Logs";
            // 
            // skiperrorscheck
            // 
            skiperrorscheck.AutoSize = true;
            skiperrorscheck.Location = new Point(7, 22);
            skiperrorscheck.Name = "skiperrorscheck";
            skiperrorscheck.Size = new Size(230, 19);
            skiperrorscheck.TabIndex = 19;
            skiperrorscheck.Text = "Skip Errors (will log them to /errors.txt)";
            skiperrorscheck.UseVisualStyleBackColor = true;
            // 
            // loglinesnumeric
            // 
            loglinesnumeric.BackColor = SystemColors.ControlDarkDark;
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
            timelabel.Location = new Point(185, 378);
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
            groupBox1.Controls.Add(regtestbutton);
            groupBox1.Controls.Add(mainnetbutton);
            groupBox1.Controls.Add(ipporttextBox);
            groupBox1.Controls.Add(label14);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(384, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 149);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Network";
            // 
            // regtestbutton
            // 
            regtestbutton.BackColor = SystemColors.ControlDarkDark;
            regtestbutton.FlatStyle = FlatStyle.Flat;
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
            mainnetbutton.BackColor = SystemColors.ControlDarkDark;
            mainnetbutton.FlatStyle = FlatStyle.Flat;
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
            ipporttextBox.BackColor = SystemColors.ControlDarkDark;
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
            label14.Location = new Point(3, 19);
            label14.Name = "label14";
            label14.Size = new Size(48, 15);
            label14.TabIndex = 0;
            label14.Text = "IP:PORT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1108, 630);
            Controls.Add(groupBox1);
            Controls.Add(timelabel);
            Controls.Add(groupBox3);
            Controls.Add(settingsgroupBox);
            Controls.Add(biddinggroupBox);
            Controls.Add(walletgroupBox);
            Controls.Add(stopbutton);
            Controls.Add(startbutton);
            Controls.Add(groupBox2);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "AUTO Bidder";
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
    }
}