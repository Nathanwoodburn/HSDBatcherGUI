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
            this.filetextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.bidnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // filetextbox
            // 
            this.filetextbox.Location = new System.Drawing.Point(79, 42);
            this.filetextbox.Name = "filetextbox";
            this.filetextbox.Size = new System.Drawing.Size(227, 23);
            this.filetextbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Domain list:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(668, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 394);
            this.listBox1.TabIndex = 4;
            this.listBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loaded Domains";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bid:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Blind:";
            // 
            // bidnumericUpDown
            // 
            this.bidnumericUpDown.DecimalPlaces = 3;
            this.bidnumericUpDown.Location = new System.Drawing.Point(51, 71);
            this.bidnumericUpDown.Name = "bidnumericUpDown";
            this.bidnumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.bidnumericUpDown.TabIndex = 1;
            // 
            // blindnumericUpDown
            // 
            this.blindnumericUpDown.DecimalPlaces = 3;
            this.blindnumericUpDown.Location = new System.Drawing.Point(51, 99);
            this.blindnumericUpDown.Name = "blindnumericUpDown";
            this.blindnumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.blindnumericUpDown.TabIndex = 2;
            this.blindnumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.TabStop = false;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "HNS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "API Key:";
            // 
            // apitextBox
            // 
            this.apitextBox.Location = new System.Drawing.Point(60, 156);
            this.apitextBox.Name = "apitextBox";
            this.apitextBox.Size = new System.Drawing.Size(282, 23);
            this.apitextBox.TabIndex = 3;
            // 
            // logtextBox
            // 
            this.logtextBox.Location = new System.Drawing.Point(11, 341);
            this.logtextBox.Multiline = true;
            this.logtextBox.Name = "logtextBox";
            this.logtextBox.ReadOnly = true;
            this.logtextBox.Size = new System.Drawing.Size(651, 97);
            this.logtextBox.TabIndex = 13;
            this.logtextBox.TabStop = false;
            this.logtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Wallet Name:";
            // 
            // wallettextBox
            // 
            this.wallettextBox.Location = new System.Drawing.Point(99, 179);
            this.wallettextBox.Name = "wallettextBox";
            this.wallettextBox.Size = new System.Drawing.Size(243, 23);
            this.wallettextBox.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(587, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.TabStop = false;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Passphrase:";
            // 
            // passtextBox
            // 
            this.passtextBox.Location = new System.Drawing.Point(89, 206);
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.Size = new System.Drawing.Size(253, 23);
            this.passtextBox.TabIndex = 5;
            this.passtextBox.UseSystemPasswordChar = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 19;
            this.button5.TabStop = false;
            this.button5.Text = "Start Bidding";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(114, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.TabStop = false;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.passtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.wallettextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.logtextBox);
            this.Controls.Add(this.apitextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.blindnumericUpDown);
            this.Controls.Add(this.bidnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filetextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AUTO Bidder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bidnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blindnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox filetextbox;
        private Button button1;
        private Label label1;
        private Button button2;
        private ListBox listBox1;
        private Label label2;
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
    }
}