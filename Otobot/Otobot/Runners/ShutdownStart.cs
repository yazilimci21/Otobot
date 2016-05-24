using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Otobot.Runners
{
    public partial class ShutdownStart : Form
    {
        enum ExitFlags : int
        {
            Logoff = 0,
            Shutdown = 1,
            Reboot = 2,
            Force = 4,
            PowerOff = 8,
            ForceIfHung = 16
        }

        public int ExitType = -1;
        int[] ints;

        public ShutdownStart()
        {
            InitializeComponent();
        }

        private void ShutdownStart_Load(object sender, EventArgs e)
        {
            string[] strings = new string[] { "Oturumu Kapat", "Bilgisayarý Kapat", "Reset At", 
                "Oturumu Kapatmaya Zorla", "Elektriði Kes", "Hata Yaþarsa Kapatmaya Zorla" };
            ints = new int[] { (int)ExitFlags.Logoff, (int)ExitFlags.Shutdown, (int)ExitFlags.Reboot,
            (int)ExitFlags.Force, (int)ExitFlags.PowerOff, (int)ExitFlags.ForceIfHung };
            for (int i = 0; i < strings.Length; i++)
            {
                comboBoxEx1.Items.Add(strings[i]);
            }
            comboBoxEx1.SelectedIndex = 0;
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEx1.SelectedIndex != -1)
            {
                ExitType = ints[comboBoxEx1.SelectedIndex];
            }
        }
    }
}