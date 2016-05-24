using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Otobot
{
    public partial class GunlukEkle : Office2007Form
    {
        public List<Types.Runner> RunList = new List<Types.Runner>();
        public Items.Item finnishItem;
        private bool set = false;

        public void SetSettings(Items.Item item)
        {
            set = true;
            if(item.RunnerList != null) RunList = new List<Types.Runner>(item.RunnerList);
            CTime1.Text = item.CreateTime.ToString("dd.MM.yyyy");
            CTime2.Text = item.CreateTime.ToString("HH:mm:ss");
            RTime1.Text = item.RunningTime.ToString("dd.MM.yyyy");
            RTime2.Text = item.RunningTime.ToString("HH:mm:ss");
            Subject.Text = item.Subject;
            if (item.AgainRepeat)
            {
                TimeSpan span = new TimeSpan(0, 0, item.AgainRunningSecond);
                RTime2.Text = span.ToString();
            }
            Body.Rtf = Encoding.Default.GetString(Convert.FromBase64String(item.Body));
            Repeat.Checked = item.Repeat;
            AgainRepeat.Checked = item.AgainRepeat;
        }

        public GunlukEkle()
        {
            InitializeComponent();
        }

        private void GunlukEkle_Load(object sender, EventArgs e)
        {
            foreach (Types.Runner runner in PluginList.RunnerList.ToArray())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = runner.Name;
                item.Tag = runner;
                CRunnerList.Items.Add(item);
            }
            CRunnerList.SelectedIndex = 0;
            if (!set)
            {
                CTime1.Value = DateTime.Now;
                CTime2.Text = DateTime.Now.ToString("HH:mm:ss");
                RTime1.Value = DateTime.Now;
                RTime2.Text = DateTime.Now.AddMinutes(30).ToString("HH:mm:ss");
            }
            foreach (Types.Runner runner in RunList.ToArray())
            {
                int a = RunnerList.Items.Count;
                RunnerList.Items.Add(runner.Name);
                RunnerList.Items[a].SubItems.Add(runner.Description);
            }
        }

        private void CRunnerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)CRunnerList.SelectedItem;
            Description.Text = "Açýklama : " + ((Types.Runner)item.Tag).Description;
        }

        private void Repeat_CheckedChanged(object sender, EventArgs e)
        {
            RTime1.Enabled = !Repeat.Checked;
            AgainRepeat.Enabled = !Repeat.Checked;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Types.Runner runner = PluginList.TypeCreator<Types.Runner>(PluginList.RunnerTypeList[CRunnerList.SelectedIndex]);
            if (runner.Create())
            {
                RunList.Add(runner);
                int a = RunnerList.Items.Count;
                RunnerList.Items.Add(runner.Name);
                RunnerList.Items[a].SubItems.Add(runner.Description);
            }
        }

        private void GunlukEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                DateTime dt = new DateTime(CTime1.Value.Year, CTime1.Value.Month, CTime1.Value.Day);
                DateTime ct = dt.AddHours(double.Parse(CTime2.Text.Substring(0, 2))).AddMinutes(double.Parse(CTime2.Text.Substring(3, 2)));
                dt = new DateTime(RTime1.Value.Year, RTime1.Value.Month, RTime1.Value.Day);
                double rthour = double.Parse(RTime2.Text.Substring(0, 2));
                double rtminute = double.Parse(RTime2.Text.Substring(3, 2));
                double rtsecond = double.Parse(RTime2.Text.Substring(6, 2));
                DateTime rt = dt.AddHours(rthour).AddMinutes(rtminute).AddSeconds(rtsecond);

                finnishItem = new Items.Item(this.Subject.Text, Convert.ToBase64String(Encoding.Default.GetBytes(this.Body.Rtf)), this.Body.Text, ct, rt, ((!AgainRepeat.Checked) ? 0 : ((((int)rthour*60)*60)+((int)rtminute*60)+(int)rtsecond)), Repeat.Checked, AgainRepeat.Checked, this.RunList.ToArray());
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RunnerList.SelectedItems.Count > 0)
            {
                int select = RunnerList.SelectedItems[0].Index;
                DialogResult result = MessageBox.Show("Seçtiðiniz çalýþtýrýcýyý silmek istediðinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) return;
                RunList.RemoveAt(select);
                RunnerList.Items[select].Remove();
            }
        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tüm çalýþtýrýcý listesini silmek istediðinizden eminmisiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            RunList.Clear();
            RunnerList.Items.Clear();
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {
            if(AgainRepeat.Checked & !set)
            MessageBox.Show("Sürede tekrar seçildiði zaman seçtiðiniz süre örneðin 10Dk içinde her 10 dakikada bir iþlemin tekrar tekrar uygulanmasý saðlanýr.", "Hatýrlatma");
            RTime1.Enabled = !AgainRepeat.Checked;
            Repeat.Enabled = !AgainRepeat.Checked;
        }
    }
}