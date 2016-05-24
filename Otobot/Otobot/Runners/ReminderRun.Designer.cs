namespace Otobot.Runners
{
    partial class ReminderRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderRun));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.Subject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Body = new WRichTextControl.WRichEditor();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 296);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(658, 15);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Baþlýk";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Subject
            // 
            this.Subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Subject.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.Subject.Border.Class = "TextBoxBorder";
            this.Subject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Subject.Location = new System.Drawing.Point(3, 317);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(657, 20);
            this.Subject.TabIndex = 4;
            // 
            // Body
            // 
            this.Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Body.BackColor = System.Drawing.Color.White;
            this.Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Body.IndentValue = 30;
            this.Body.IsEnabled = true;
            this.Body.Location = new System.Drawing.Point(3, 343);
            this.Body.ModifiedState = false;
            this.Body.Name = "Body";
            this.Body.Rtf = "{\\rtf1\\ansi\\ansicpg1254\\deff0\\deflang1055{\\fonttbl{\\f0\\fnil\\fcharset162 Microsoft" +
                " Sans Serif;}}\r\n{\\*\\generator Msftedit 5.41.21.2510;}\\viewkind4\\uc1\\pard\\f0\\fs20" +
                "\\par\r\n}\r\n";
            this.Body.Size = new System.Drawing.Size(656, 178);
            this.Body.TabIndex = 3;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(662, 290);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            // 
            // ReminderRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 524);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "ReminderRun";
            this.Text = "ReminderRun";
            this.Load += new System.EventHandler(this.ReminderRun_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReminderRun_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.Controls.TextBoxX Subject;
        public WRichTextControl.WRichEditor Body;
    }
}