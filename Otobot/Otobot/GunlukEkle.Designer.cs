namespace Otobot
{
    partial class GunlukEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GunlukEkle));
            this.Body = new WRichTextControl.WRichEditor();
            this.Subject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.OK = new DevComponents.DotNetBar.ButtonX();
            this.Cancel = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.CTime2 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.CTime1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AgainRepeat = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.Repeat = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.RTime2 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.RTime1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.RunnerList = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.RName = new System.Windows.Forms.ColumnHeader();
            this.RDesc = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CRunnerList = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.Description = new DevComponents.DotNetBar.LabelX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTime1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTime1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Body.BackColor = System.Drawing.Color.White;
            this.Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Body.IndentValue = 30;
            this.Body.IsEnabled = true;
            this.Body.Location = new System.Drawing.Point(1, 120);
            this.Body.ModifiedState = false;
            this.Body.Name = "Body";
            this.Body.Rtf = "{\\rtf1\\ansi\\ansicpg1254\\deff0\\deflang1055{\\fonttbl{\\f0\\fnil\\fcharset162 Microsoft" +
                " Sans Serif;}}\r\n{\\*\\generator Msftedit 5.41.21.2510;}\\viewkind4\\uc1\\pard\\f0\\fs20" +
                "\\par\r\n}\r\n";
            this.Body.Size = new System.Drawing.Size(453, 348);
            this.Body.TabIndex = 0;
            // 
            // Subject
            // 
            this.Subject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Subject.Border.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.Subject.Border.Class = "TextBoxBorder";
            this.Subject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Subject.Location = new System.Drawing.Point(1, 94);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(454, 20);
            this.Subject.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(1, 73);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(455, 15);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Baþlýk";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // OK
            // 
            this.OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(547, 474);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.OK.TabIndex = 3;
            this.OK.Text = "Tamam";
            // 
            // Cancel
            // 
            this.Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(628, 474);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Vazgeç";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.CTime2);
            this.groupBox1.Controls.Add(this.CTime1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oluþturulma Ayarlarý";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(6, 38);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(127, 20);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "Oluþturma Saati";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(6, 13);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(127, 20);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Oluþturma Tarihi";
            // 
            // CTime2
            // 
            // 
            // 
            // 
            this.CTime2.BackgroundStyle.Class = "TextBoxBorder";
            this.CTime2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CTime2.ButtonClear.Visible = true;
            this.CTime2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CTime2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.CTime2.Location = new System.Drawing.Point(140, 38);
            this.CTime2.Mask = "00:00:00";
            this.CTime2.Name = "CTime2";
            this.CTime2.Size = new System.Drawing.Size(200, 20);
            this.CTime2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CTime2.TabIndex = 2;
            this.CTime2.Text = "";
            this.CTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CTime2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            // 
            // CTime1
            // 
            // 
            // 
            // 
            this.CTime1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.CTime1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CTime1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.CTime1.ButtonDropDown.Visible = true;
            this.CTime1.IsPopupCalendarOpen = false;
            this.CTime1.Location = new System.Drawing.Point(140, 13);
            // 
            // 
            // 
            this.CTime1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.CTime1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.CTime1.MonthCalendar.BackgroundStyle.Class = "";
            this.CTime1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CTime1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.CTime1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.CTime1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.CTime1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.CTime1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.CTime1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.CTime1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.CTime1.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.CTime1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CTime1.MonthCalendar.DisplayMonth = new System.DateTime(2013, 8, 1, 0, 0, 0, 0);
            this.CTime1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.CTime1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.CTime1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.CTime1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.CTime1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.CTime1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.CTime1.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.CTime1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CTime1.MonthCalendar.TodayButtonVisible = true;
            this.CTime1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.CTime1.Name = "CTime1";
            this.CTime1.Size = new System.Drawing.Size(200, 20);
            this.CTime1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CTime1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AgainRepeat);
            this.groupBox2.Controls.Add(this.Repeat);
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.RTime2);
            this.groupBox2.Controls.Add(this.RTime1);
            this.groupBox2.Location = new System.Drawing.Point(353, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 68);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çalýþma Ayarlarý";
            // 
            // AgainRepeat
            // 
            // 
            // 
            // 
            this.AgainRepeat.BackgroundStyle.Class = "";
            this.AgainRepeat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.AgainRepeat.Location = new System.Drawing.Point(245, 35);
            this.AgainRepeat.Name = "AgainRepeat";
            this.AgainRepeat.Size = new System.Drawing.Size(94, 23);
            this.AgainRepeat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AgainRepeat.TabIndex = 5;
            this.AgainRepeat.Text = "Sürede Tekrar";
            this.AgainRepeat.CheckedChanged += new System.EventHandler(this.checkBoxX1_CheckedChanged);
            // 
            // Repeat
            // 
            // 
            // 
            // 
            this.Repeat.BackgroundStyle.Class = "";
            this.Repeat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Repeat.Location = new System.Drawing.Point(244, 12);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(94, 23);
            this.Repeat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Repeat.TabIndex = 4;
            this.Repeat.Text = "Hergün Tekrar";
            this.Repeat.CheckedChanged += new System.EventHandler(this.Repeat_CheckedChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(6, 38);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(127, 20);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Çalýþma Saati";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(6, 13);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(127, 20);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Çalýþma Tarihi";
            // 
            // RTime2
            // 
            // 
            // 
            // 
            this.RTime2.BackgroundStyle.Class = "TextBoxBorder";
            this.RTime2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RTime2.ButtonClear.Visible = true;
            this.RTime2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.RTime2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.RTime2.Location = new System.Drawing.Point(139, 38);
            this.RTime2.Mask = "00:00:00";
            this.RTime2.Name = "RTime2";
            this.RTime2.Size = new System.Drawing.Size(99, 20);
            this.RTime2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RTime2.TabIndex = 1;
            this.RTime2.Text = "";
            this.RTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RTime2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            // 
            // RTime1
            // 
            // 
            // 
            // 
            this.RTime1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.RTime1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RTime1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.RTime1.ButtonDropDown.Visible = true;
            this.RTime1.IsPopupCalendarOpen = false;
            this.RTime1.Location = new System.Drawing.Point(139, 13);
            // 
            // 
            // 
            this.RTime1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.RTime1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.RTime1.MonthCalendar.BackgroundStyle.Class = "";
            this.RTime1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RTime1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.RTime1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.RTime1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.RTime1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.RTime1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.RTime1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.RTime1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.RTime1.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.RTime1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RTime1.MonthCalendar.DisplayMonth = new System.DateTime(2013, 8, 1, 0, 0, 0, 0);
            this.RTime1.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.RTime1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.RTime1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.RTime1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.RTime1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.RTime1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.RTime1.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.RTime1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RTime1.MonthCalendar.TodayButtonVisible = true;
            this.RTime1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.RTime1.Name = "RTime1";
            this.RTime1.Size = new System.Drawing.Size(99, 20);
            this.RTime1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RTime1.TabIndex = 0;
            // 
            // labelX6
            // 
            this.labelX6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(462, 73);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(241, 15);
            this.labelX6.TabIndex = 7;
            this.labelX6.Text = "Çalýþtýrýcýlar";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // RunnerList
            // 
            this.RunnerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.RunnerList.Border.Class = "ListViewBorder";
            this.RunnerList.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RunnerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RName,
            this.RDesc});
            this.RunnerList.ContextMenuStrip = this.contextMenuStrip1;
            this.RunnerList.FullRowSelect = true;
            this.RunnerList.Location = new System.Drawing.Point(462, 175);
            this.RunnerList.Name = "RunnerList";
            this.RunnerList.Size = new System.Drawing.Size(236, 293);
            this.RunnerList.TabIndex = 8;
            this.RunnerList.UseCompatibleStateImageBehavior = false;
            this.RunnerList.View = System.Windows.Forms.View.Details;
            // 
            // RName
            // 
            this.RName.Text = "Ýsmi";
            this.RName.Width = 76;
            // 
            // RDesc
            // 
            this.RDesc.Text = "Açýklama";
            this.RDesc.Width = 148;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.temizleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // CRunnerList
            // 
            this.CRunnerList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CRunnerList.DisplayMember = "Text";
            this.CRunnerList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CRunnerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CRunnerList.FormattingEnabled = true;
            this.CRunnerList.ItemHeight = 14;
            this.CRunnerList.Location = new System.Drawing.Point(462, 94);
            this.CRunnerList.Name = "CRunnerList";
            this.CRunnerList.Size = new System.Drawing.Size(160, 20);
            this.CRunnerList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CRunnerList.TabIndex = 9;
            this.CRunnerList.SelectedIndexChanged += new System.EventHandler(this.CRunnerList_SelectedIndexChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(633, 94);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(70, 20);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 10;
            this.buttonX1.Text = "Ekle";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.Description.BackgroundStyle.Class = "";
            this.Description.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Description.Location = new System.Drawing.Point(462, 120);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(236, 49);
            this.Description.TabIndex = 11;
            this.Description.Text = "Açýklama :";
            this.Description.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.Description.WordWrap = true;
            // 
            // GunlukEkle
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(226)))));
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(704, 500);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.CRunnerList);
            this.Controls.Add(this.RunnerList);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.Body);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GunlukEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekle";
            this.Load += new System.EventHandler(this.GunlukEkle_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GunlukEkle_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CTime1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RTime1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX OK;
        private DevComponents.DotNetBar.ButtonX Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ListViewEx RunnerList;
        private DevComponents.DotNetBar.Controls.ComboBoxEx CRunnerList;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX Description;
        public WRichTextControl.WRichEditor Body;
        public DevComponents.DotNetBar.Controls.TextBoxX Subject;
        protected DevComponents.DotNetBar.Controls.MaskedTextBoxAdv CTime2;
        protected DevComponents.Editors.DateTimeAdv.DateTimeInput CTime1;
        protected DevComponents.DotNetBar.Controls.MaskedTextBoxAdv RTime2;
        protected DevComponents.Editors.DateTimeAdv.DateTimeInput RTime1;
        public DevComponents.DotNetBar.Controls.CheckBoxX Repeat;
        private System.Windows.Forms.ColumnHeader RName;
        private System.Windows.Forms.ColumnHeader RDesc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        public DevComponents.DotNetBar.Controls.CheckBoxX AgainRepeat;
    }
}