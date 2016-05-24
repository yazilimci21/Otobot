namespace Otobot.Runners
{
    partial class OpenProcessStart
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
            this.OtherFolder = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WorkingDirectory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DomainName = new System.Windows.Forms.ComboBox();
            this.OpenAs = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userAcounts = new System.Windows.Forms.ComboBox();
            this.Program = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblParametreler = new System.Windows.Forms.Label();
            this.Parametreler = new System.Windows.Forms.TextBox();
            this.Gozat = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ErrorDialog = new System.Windows.Forms.CheckBox();
            this.WindowStyle = new System.Windows.Forms.ComboBox();
            this.CreateNoWindow = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OtherFolder
            // 
            this.OtherFolder.AutoSize = true;
            this.OtherFolder.Location = new System.Drawing.Point(347, 198);
            this.OtherFolder.Name = "OtherFolder";
            this.OtherFolder.Size = new System.Drawing.Size(131, 17);
            this.OtherFolder.TabIndex = 27;
            this.OtherFolder.Text = "Farklý klasörde çalýþsýn";
            this.OtherFolder.UseVisualStyleBackColor = true;
            this.OtherFolder.CheckedChanged += new System.EventHandler(this.OtherFolder_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WorkingDirectory);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(14, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 56);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Klasör ayarlarý";
            // 
            // WorkingDirectory
            // 
            this.WorkingDirectory.Location = new System.Drawing.Point(9, 19);
            this.WorkingDirectory.Name = "WorkingDirectory";
            this.WorkingDirectory.Size = new System.Drawing.Size(369, 20);
            this.WorkingDirectory.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gözat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DomainName
            // 
            this.DomainName.FormattingEnabled = true;
            this.DomainName.Location = new System.Drawing.Point(97, 27);
            this.DomainName.Name = "DomainName";
            this.DomainName.Size = new System.Drawing.Size(281, 21);
            this.DomainName.TabIndex = 9;
            // 
            // OpenAs
            // 
            this.OpenAs.AutoSize = true;
            this.OpenAs.Location = new System.Drawing.Point(395, 85);
            this.OpenAs.Name = "OpenAs";
            this.OpenAs.Size = new System.Drawing.Size(83, 17);
            this.OpenAs.TabIndex = 24;
            this.OpenAs.Text = "Farklý çalýþtýr";
            this.OpenAs.UseVisualStyleBackColor = true;
            this.OpenAs.CheckedChanged += new System.EventHandler(this.OpenAs_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DomainName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.userPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.userAcounts);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(14, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 107);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Farklý çalýþtýrma ayarlarý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Domain Ýsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Þifre";
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(97, 80);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(281, 20);
            this.userPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanýcý adý";
            // 
            // userAcounts
            // 
            this.userAcounts.FormattingEnabled = true;
            this.userAcounts.Location = new System.Drawing.Point(97, 53);
            this.userAcounts.Name = "userAcounts";
            this.userAcounts.Size = new System.Drawing.Size(281, 21);
            this.userAcounts.TabIndex = 0;
            // 
            // Program
            // 
            this.Program.Location = new System.Drawing.Point(14, 15);
            this.Program.Name = "Program";
            this.Program.Size = new System.Drawing.Size(378, 20);
            this.Program.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pencere stili";
            // 
            // LblParametreler
            // 
            this.LblParametreler.AutoSize = true;
            this.LblParametreler.Location = new System.Drawing.Point(11, 44);
            this.LblParametreler.Name = "LblParametreler";
            this.LblParametreler.Size = new System.Drawing.Size(94, 13);
            this.LblParametreler.TabIndex = 18;
            this.LblParametreler.Text = "Açýlýþ parametreleri";
            // 
            // Parametreler
            // 
            this.Parametreler.Location = new System.Drawing.Point(111, 41);
            this.Parametreler.Name = "Parametreler";
            this.Parametreler.Size = new System.Drawing.Size(281, 20);
            this.Parametreler.TabIndex = 17;
            // 
            // Gozat
            // 
            this.Gozat.Location = new System.Drawing.Point(398, 11);
            this.Gozat.Name = "Gozat";
            this.Gozat.Size = new System.Drawing.Size(80, 26);
            this.Gozat.TabIndex = 15;
            this.Gozat.Text = "Gözat";
            this.Gozat.UseVisualStyleBackColor = true;
            this.Gozat.Click += new System.EventHandler(this.Gozat_Click);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(312, 293);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 26);
            this.OK.TabIndex = 19;
            this.OK.Text = "Tamam";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(398, 293);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 26);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "Vazgeç";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // ErrorDialog
            // 
            this.ErrorDialog.AutoSize = true;
            this.ErrorDialog.Checked = true;
            this.ErrorDialog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ErrorDialog.Location = new System.Drawing.Point(382, 271);
            this.ErrorDialog.Name = "ErrorDialog";
            this.ErrorDialog.Size = new System.Drawing.Size(96, 17);
            this.ErrorDialog.TabIndex = 29;
            this.ErrorDialog.Text = "Hata Göstersin";
            this.ErrorDialog.UseVisualStyleBackColor = true;
            // 
            // WindowStyle
            // 
            this.WindowStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WindowStyle.FormattingEnabled = true;
            this.WindowStyle.Location = new System.Drawing.Point(111, 66);
            this.WindowStyle.Name = "WindowStyle";
            this.WindowStyle.Size = new System.Drawing.Size(179, 21);
            this.WindowStyle.TabIndex = 22;
            // 
            // CreateNoWindow
            // 
            this.CreateNoWindow.AutoSize = true;
            this.CreateNoWindow.Checked = true;
            this.CreateNoWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreateNoWindow.Location = new System.Drawing.Point(296, 68);
            this.CreateNoWindow.Name = "CreateNoWindow";
            this.CreateNoWindow.Size = new System.Drawing.Size(96, 17);
            this.CreateNoWindow.TabIndex = 21;
            this.CreateNoWindow.Text = "Pencere Olsun";
            this.CreateNoWindow.UseVisualStyleBackColor = true;
            // 
            // OpenProcessStart
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(488, 331);
            this.Controls.Add(this.OtherFolder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.OpenAs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Program);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblParametreler);
            this.Controls.Add(this.Parametreler);
            this.Controls.Add(this.Gozat);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ErrorDialog);
            this.Controls.Add(this.WindowStyle);
            this.Controls.Add(this.CreateNoWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OpenProcessStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Açýcý";
            this.Load += new System.EventHandler(this.OpenProcessStart_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenProcessStart_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox OtherFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox WorkingDirectory;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox DomainName;
        public System.Windows.Forms.CheckBox OpenAs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox userAcounts;
        public System.Windows.Forms.TextBox Program;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblParametreler;
        public System.Windows.Forms.TextBox Parametreler;
        private System.Windows.Forms.Button Gozat;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.CheckBox ErrorDialog;
        public System.Windows.Forms.ComboBox WindowStyle;
        public System.Windows.Forms.CheckBox CreateNoWindow;

    }
}