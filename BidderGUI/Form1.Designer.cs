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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.domainslistBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bidnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blindnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.apitextBox = new System.Windows.Forms.TextBox();
            this.logtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.wallettextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.passtextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.intervalnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.modecomboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removebutton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.domaintextBox = new System.Windows.Forms.TextBox();
            this.biddinggroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bidnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.biddinggroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "Import Domains";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // domainslistBox
            // 
            this.domainslistBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.domainslistBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.domainslistBox.ForeColor = System.Drawing.Color.White;
            this.domainslistBox.FormattingEnabled = true;
            this.domainslistBox.ItemHeight = 15;
            this.domainslistBox.Location = new System.Drawing.Point(213, 19);
            this.domainslistBox.Name = "domainslistBox";
            this.domainslistBox.Size = new System.Drawing.Size(138, 334);
            this.domainslistBox.TabIndex = 4;
            this.domainslistBox.TabStop = false;
            this.domainslistBox.SelectedIndexChanged += new System.EventHandler(this.domainslistBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bid:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Blind:";
            // 
            // bidnumericUpDown
            // 
            this.bidnumericUpDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bidnumericUpDown.DecimalPlaces = 3;
            this.bidnumericUpDown.ForeColor = System.Drawing.Color.White;
            this.bidnumericUpDown.Location = new System.Drawing.Point(49, 17);
            this.bidnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.bidnumericUpDown.Name = "bidnumericUpDown";
            this.bidnumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.bidnumericUpDown.TabIndex = 4;
            this.bidnumericUpDown.ThousandsSeparator = true;
            // 
            // blindnumericUpDown
            // 
            this.blindnumericUpDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.blindnumericUpDown.DecimalPlaces = 3;
            this.blindnumericUpDown.ForeColor = System.Drawing.Color.White;
            this.blindnumericUpDown.Location = new System.Drawing.Point(49, 46);
            this.blindnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.blindnumericUpDown.Name = "blindnumericUpDown";
            this.blindnumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.blindnumericUpDown.TabIndex = 5;
            this.blindnumericUpDown.ThousandsSeparator = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(349, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.TabStop = false;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "HNS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "API Key:";
            // 
            // apitextBox
            // 
            this.apitextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.apitextBox.ForeColor = System.Drawing.Color.White;
            this.apitextBox.Location = new System.Drawing.Point(57, 19);
            this.apitextBox.Name = "apitextBox";
            this.apitextBox.Size = new System.Drawing.Size(275, 23);
            this.apitextBox.TabIndex = 0;
            // 
            // logtextBox
            // 
            this.logtextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logtextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logtextBox.ForeColor = System.Drawing.Color.White;
            this.logtextBox.Location = new System.Drawing.Point(3, 51);
            this.logtextBox.Multiline = true;
            this.logtextBox.Name = "logtextBox";
            this.logtextBox.ReadOnly = true;
            this.logtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logtextBox.Size = new System.Drawing.Size(1079, 149);
            this.logtextBox.TabIndex = 13;
            this.logtextBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Wallet Name:";
            // 
            // wallettextBox
            // 
            this.wallettextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wallettextBox.ForeColor = System.Drawing.Color.White;
            this.wallettextBox.Location = new System.Drawing.Point(88, 48);
            this.wallettextBox.Name = "wallettextBox";
            this.wallettextBox.Size = new System.Drawing.Size(243, 23);
            this.wallettextBox.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1004, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.TabStop = false;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Passphrase:";
            // 
            // passtextBox
            // 
            this.passtextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passtextBox.ForeColor = System.Drawing.Color.White;
            this.passtextBox.Location = new System.Drawing.Point(78, 77);
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.Size = new System.Drawing.Size(253, 23);
            this.passtextBox.TabIndex = 2;
            this.passtextBox.UseSystemPasswordChar = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(12, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Start";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(108, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Batch Interval:";
            // 
            // intervalnumericUpDown
            // 
            this.intervalnumericUpDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.intervalnumericUpDown.ForeColor = System.Drawing.Color.White;
            this.intervalnumericUpDown.Location = new System.Drawing.Point(88, 46);
            this.intervalnumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.intervalnumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intervalnumericUpDown.Name = "intervalnumericUpDown";
            this.intervalnumericUpDown.Size = new System.Drawing.Size(99, 23);
            this.intervalnumericUpDown.TabIndex = 4;
            this.intervalnumericUpDown.TabStop = false;
            this.intervalnumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "minutes";
            // 
            // modecomboBox
            // 
            this.modecomboBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.modecomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modecomboBox.ForeColor = System.Drawing.Color.White;
            this.modecomboBox.FormattingEnabled = true;
            this.modecomboBox.Items.AddRange(new object[] {
            "OPEN",
            "BID",
            "REVEAL",
            "REDEEM"});
            this.modecomboBox.Location = new System.Drawing.Point(88, 75);
            this.modecomboBox.Name = "modecomboBox";
            this.modecomboBox.Size = new System.Drawing.Size(99, 23);
            this.modecomboBox.TabIndex = 3;
            this.modecomboBox.Text = "BID";
            this.modecomboBox.SelectedIndexChanged += new System.EventHandler(this.modecomboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Mode:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.wallettextBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.apitextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.passtextBox);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wallet";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.removebutton);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.domaintextBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.domainslistBox);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(742, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 356);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Domains";
            // 
            // removebutton
            // 
            this.removebutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.removebutton.Enabled = false;
            this.removebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removebutton.Location = new System.Drawing.Point(100, 175);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(107, 23);
            this.removebutton.TabIndex = 9;
            this.removebutton.TabStop = false;
            this.removebutton.Text = "Remove Selected";
            this.removebutton.UseVisualStyleBackColor = false;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(6, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.TabStop = false;
            this.button7.Text = "Clear All";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(114, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 7;
            this.button2.TabStop = false;
            this.button2.Text = "Add to list";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Domain:";
            // 
            // domaintextBox
            // 
            this.domaintextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.domaintextBox.ForeColor = System.Drawing.Color.White;
            this.domaintextBox.Location = new System.Drawing.Point(64, 82);
            this.domaintextBox.Name = "domaintextBox";
            this.domaintextBox.Size = new System.Drawing.Size(143, 23);
            this.domaintextBox.TabIndex = 5;
            this.domaintextBox.TabStop = false;
            // 
            // biddinggroupBox
            // 
            this.biddinggroupBox.BackColor = System.Drawing.Color.Black;
            this.biddinggroupBox.Controls.Add(this.bidnumericUpDown);
            this.biddinggroupBox.Controls.Add(this.label3);
            this.biddinggroupBox.Controls.Add(this.label4);
            this.biddinggroupBox.Controls.Add(this.blindnumericUpDown);
            this.biddinggroupBox.Controls.Add(this.label2);
            this.biddinggroupBox.Controls.Add(this.label5);
            this.biddinggroupBox.ForeColor = System.Drawing.Color.White;
            this.biddinggroupBox.Location = new System.Drawing.Point(11, 253);
            this.biddinggroupBox.Name = "biddinggroupBox";
            this.biddinggroupBox.Size = new System.Drawing.Size(345, 85);
            this.biddinggroupBox.TabIndex = 4;
            this.biddinggroupBox.TabStop = false;
            this.biddinggroupBox.Text = "Bidding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "HNS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Batch Size:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(88, 17);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.intervalnumericUpDown);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.modecomboBox);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(11, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 106);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(193, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "domains";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.logtextBox);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(11, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1085, 203);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1108, 589);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.biddinggroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AUTO Bidder";
            ((System.ComponentModel.ISupportInitialize)(this.bidnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.biddinggroupBox.ResumeLayout(false);
            this.biddinggroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private Button button5;
        private Button button6;
        private Label label9;
        private NumericUpDown intervalnumericUpDown;
        private Label label10;
        private ComboBox modecomboBox;
        private Label label11;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label1;
        private TextBox domaintextBox;
        private Button button7;
        private Button removebutton;
        private GroupBox biddinggroupBox;
        private Label label2;
        private Label label12;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox4;
        private Label label13;
        private GroupBox groupBox3;
    }
}