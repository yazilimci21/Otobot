using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Otobot.Runners
{
    public partial class CloseProcessStart : Form
    {
        public int processId;
        public IntPtr processHandle;
        public int selectedIndex = -1;
        public string processName="";

        public CloseProcessStart()
        {
            InitializeComponent();
        }

        private void CloseProcessStart_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            listView1.Items.Clear();
            ýmageList1.Images.Clear();
            foreach (Process proc in Process.GetProcesses())
            {
                int item = listView1.Items.Count;
                try
                {
                    listView1.Items.Add(proc.Handle.ToString());
                }
                catch
                {
                    continue;
                }
                ýmageList1.Images.Add(IconExtractor.geticon(proc.MainModule.FileName));
                listView1.Items[item].SubItems.Add(proc.Id.ToString());
                listView1.Items[item].SubItems.Add(proc.ProcessName);
                listView1.Items[item].ImageIndex = item;
                listView1.Items[item].Tag = proc;
            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void CloseProcessStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (TxtprocessName.Text != "")
                {
                    processName = TxtprocessName.Text;
                }
                else
                {
                    try
                    {
                        Process proc = (Process)listView1.Items[selectedIndex].Tag;
                        this.processHandle = proc.Handle;
                        this.processId = proc.Id;
                    }
                    catch { this.DialogResult = DialogResult.Cancel; }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            selectedIndex = listView1.SelectedItems[0].Index;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}