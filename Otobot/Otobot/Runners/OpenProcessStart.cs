using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;

namespace Otobot.Runners
{
    public partial class OpenProcessStart : Form
    {
        public Process process = new Process();
        
        public OpenProcessStart()
        {
            InitializeComponent();
        }

        private void Gozat_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Bütün dosyalar|*.exe";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Program.Text = open.FileName;
            }
        }

        private void OpenProcessStart_Load(object sender, EventArgs e)
        {
            foreach (object val in Enum.GetValues(typeof(ProcessWindowStyle)))
            {
                WindowStyle.Items.Add(val.ToString());
            }
            WindowStyle.SelectedIndex = 0;
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject envVar in searcher.Get())
            {
                userAcounts.Items.Add(envVar["Name"]);
            }
            userAcounts.SelectedIndex = 0;
            DomainName.Items.Add(Environment.UserDomainName);
            DomainName.SelectedIndex = 0;
        }

        private void OpenAs_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = OpenAs.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                WorkingDirectory.Text = folder.SelectedPath;
            }
        }

        private void OtherFolder_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = OtherFolder.Checked;
        }

        private void OpenProcessStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                string program = this.Program.Text;
                string parametreler = this.Parametreler.Text;
                bool createNoWindow = this.CreateNoWindow.Checked;
                bool UseShellExecute = false;
                bool OpenAs = this.OpenAs.Checked;
                bool startOtherFolder = this.OtherFolder.Checked;
                bool ErrorDialog = this.ErrorDialog.Checked;
                string WindowStyle = this.WindowStyle.Text;
                string UserName = this.userAcounts.Text;
                string UserPassword = this.userPassword.Text;
                string WorkingDirectory = this.WorkingDirectory.Text;
                string Domain = this.DomainName.Text;

                if (!string.IsNullOrEmpty(program))
                {
                    ProcessStartInfo info = new ProcessStartInfo();
                    info.FileName = program;
                    info.Arguments = parametreler;
                    info.LoadUserProfile = OpenAs;
                    if (info.LoadUserProfile)
                    {
                        info.Domain = Domain;
                        info.UserName = UserName;
                        System.Security.SecureString pass = new System.Security.SecureString();
                        foreach (Char character in UserPassword)
                        {
                            pass.AppendChar(character);
                        }
                        info.Password = pass;
                    }
                    if (startOtherFolder)
                        info.WorkingDirectory = WorkingDirectory;
                    info.ErrorDialog = ErrorDialog;

                    info.UseShellExecute = UseShellExecute;
                    if (!info.UseShellExecute)
                    {
                        info.RedirectStandardError = true;
                        info.RedirectStandardInput = true;
                        info.RedirectStandardOutput = true;
                        info.StandardErrorEncoding = Encoding.ASCII;
                        info.StandardOutputEncoding = Encoding.ASCII;
                    }
                    info.WindowStyle = (ProcessWindowStyle)Enum.Parse(typeof(ProcessWindowStyle), WindowStyle);
                    info.CreateNoWindow = !createNoWindow;
                    if (info.CreateNoWindow) info.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo = info;
                    process.EnableRaisingEvents = true;
                }
                else this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}