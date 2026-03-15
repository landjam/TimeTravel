namespace TimeTravel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.settings = new System.Windows.Forms.GroupBox();
            this.assumeFormBox = new System.Windows.Forms.CheckBox();
            this.deterministicBox = new System.Windows.Forms.CheckBox();
            this.sqwimbleBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.longitudeBox = new System.Windows.Forms.TextBox();
            this.latitudeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eraBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.George = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqwimbleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.George)).BeginInit();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.Controls.Add(this.assumeFormBox);
            this.settings.Controls.Add(this.deterministicBox);
            this.settings.Controls.Add(this.sqwimbleBar);
            this.settings.Controls.Add(this.label8);
            this.settings.Controls.Add(this.startButton);
            this.settings.Controls.Add(this.longitudeBox);
            this.settings.Controls.Add(this.latitudeBox);
            this.settings.Controls.Add(this.label7);
            this.settings.Controls.Add(this.label6);
            this.settings.Controls.Add(this.label5);
            this.settings.Controls.Add(this.eraBox);
            this.settings.Controls.Add(this.yearBox);
            this.settings.Controls.Add(this.label4);
            this.settings.Controls.Add(this.dayBox);
            this.settings.Controls.Add(this.monthBox);
            this.settings.Controls.Add(this.label3);
            this.settings.Controls.Add(this.label2);
            this.settings.Controls.Add(this.label1);
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settings.Location = new System.Drawing.Point(3, 209);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(708, 221);
            this.settings.TabIndex = 1;
            this.settings.TabStop = false;
            this.settings.Text = "Settings";
            // 
            // assumeFormBox
            // 
            this.assumeFormBox.AutoSize = true;
            this.assumeFormBox.Location = new System.Drawing.Point(435, 128);
            this.assumeFormBox.Name = "assumeFormBox";
            this.assumeFormBox.Size = new System.Drawing.Size(89, 17);
            this.assumeFormBox.TabIndex = 18;
            this.assumeFormBox.Text = "Assume Form";
            this.assumeFormBox.UseVisualStyleBackColor = true;
            // 
            // deterministicBox
            // 
            this.deterministicBox.AutoSize = true;
            this.deterministicBox.Location = new System.Drawing.Point(435, 102);
            this.deterministicBox.Name = "deterministicBox";
            this.deterministicBox.Size = new System.Drawing.Size(86, 17);
            this.deterministicBox.TabIndex = 17;
            this.deterministicBox.Text = "Deterministic";
            this.deterministicBox.UseVisualStyleBackColor = true;
            // 
            // sqwimbleBar
            // 
            this.sqwimbleBar.Location = new System.Drawing.Point(527, 57);
            this.sqwimbleBar.Maximum = 100;
            this.sqwimbleBar.Minimum = -100;
            this.sqwimbleBar.Name = "sqwimbleBar";
            this.sqwimbleBar.Size = new System.Drawing.Size(172, 45);
            this.sqwimbleBar.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(432, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sqwimble";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(317, 176);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 36);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // longitudeBox
            // 
            this.longitudeBox.Location = new System.Drawing.Point(150, 128);
            this.longitudeBox.Name = "longitudeBox";
            this.longitudeBox.Size = new System.Drawing.Size(157, 20);
            this.longitudeBox.TabIndex = 13;
            // 
            // latitudeBox
            // 
            this.latitudeBox.Location = new System.Drawing.Point(150, 102);
            this.latitudeBox.Name = "latitudeBox";
            this.latitudeBox.Size = new System.Drawing.Size(157, 20);
            this.latitudeBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Long.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lat.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Location";
            // 
            // eraBox
            // 
            this.eraBox.FormattingEnabled = true;
            this.eraBox.Items.AddRange(new object[] {
            "BC",
            "CE"});
            this.eraBox.Location = new System.Drawing.Point(267, 57);
            this.eraBox.Name = "eraBox";
            this.eraBox.Size = new System.Drawing.Size(40, 21);
            this.eraBox.TabIndex = 8;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(207, 58);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(56, 20);
            this.yearBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y";
            // 
            // dayBox
            // 
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayBox.Location = new System.Drawing.Point(92, 57);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(36, 21);
            this.dayBox.TabIndex = 0;
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.monthBox.Location = new System.Drawing.Point(150, 57);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(36, 21);
            this.monthBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "D";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // George
            // 
            this.George.BackgroundImage = global::TimeTravel.Properties.Resources.GWB;
            this.George.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.George.Location = new System.Drawing.Point(3, -175);
            this.George.Name = "George";
            this.George.Size = new System.Drawing.Size(708, 418);
            this.George.TabIndex = 2;
            this.George.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(714, 433);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.George);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Travel v1.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqwimbleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.George)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.PictureBox George;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox eraBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox longitudeBox;
        private System.Windows.Forms.TextBox latitudeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox assumeFormBox;
        private System.Windows.Forms.CheckBox deterministicBox;
        private System.Windows.Forms.TrackBar sqwimbleBar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

