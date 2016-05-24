using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Otobot.Runners
{
    public partial class ReminderStart : Form
    {
        public int volume;
        public string file;

        public ReminderStart()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Tüm Ortam Dosyalarý|*.wav;*.aif;*.aiff;*.aifc;*.snd;*.mp3;*.au;*.mpa;*.mp2;*.wma;*.asf;*.avi;*.mpg;*.m1v;*.mp2;*.mp2v;*.mpeg;*.mpe;*.mpv2;*.wm;*.wmv;*.asf;*.flv;*.mp4;*.dat;*.data;|" +
                    "Video Formatlarý|*.avi;*.mpg;*.m1v;*.mp2;*.mp2v;*.mpeg;*.mpe;*.mpv2;*.wm;*.wmv;*.asf;*.flv;*.mp4;*.dat;*.data;|" +
                    "Müzik Formatlarý|*.mp3;*.ram;*.rm;*.wav;*.wma;*.mid;*.aif;*.aiff;*.aifc;*.snd;*.au;*.mpa;*.mp2;*.wma;*.asf;|Tüm Dosyalar|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                textBoxX1.Text = open.FileName;
                axWindowsMediaPlayer1.URL = open.FileName;
            }
        }

        private void ReminderStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBoxX1.Text != "" & axWindowsMediaPlayer1.URL != "")
            {
                volume = ((axWindowsMediaPlayer1.settings.mute) ? 0 : axWindowsMediaPlayer1.settings.volume);
                file = axWindowsMediaPlayer1.URL;
            }
            else
                this.DialogResult = DialogResult.Cancel;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.close();
        }
    }
}