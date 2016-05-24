using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;

namespace Otobot
{
    public partial class Form1 : Office2007Form
    {
        private List<Items.Item> itemList = new List<Items.Item>();

        public Form1()
        {
            InitializeComponent();
            PluginList.ReadAllPluginsInTypes();
            SaveList.ReadAllSaveFiles();
            if (SaveList.saveList.Count > 0)
            {
                if(SaveList.saveList[0].Items != null) itemList = new List<Items.Item>(SaveList.saveList[0].Items);
                else itemList = new List<Items.Item>();
            }
            else itemList = new List<Items.Item>();
            findStyleBox.SelectedIndex = 0;
            RefreshList();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
            notifyIcon1.Dispose();
            Items.ItemList itemListsave = new Items.ItemList();
            itemListsave.Items = itemList.ToArray();
            itemListsave.GroupName = "DefaultList";
            SaveList.AddedOrChangeItemList(itemListsave);
            SaveList.SaveAllSaveFiles();
        }

        private void RefreshList()
        {
            searchText.Text = "";
            ItemListView.Items.Clear();
            itemList.FindAll(new Predicate<Items.Item>(find));
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            ItemListView.Items.Clear();
            itemList.FindAll(new Predicate<Items.Item>(find));
        }

        private bool find(Items.Item item)
        {
            bool finding = item.Find(searchText.Text, findStyleBox.SelectedIndex);
            if (finding)
            {
                item.WorkingControl();
                int itemcnt = ItemListView.Items.Count;
                ItemListView.Items.Add(((item.Repeat) ? "Evet" : "Hayir"));
                ItemListView.Items[itemcnt].SubItems.Add(((item.AgainRepeat) ? "Evet" : "Hayir"));
                ItemListView.Items[itemcnt].SubItems.Add(item.Subject);
                ItemListView.Items[itemcnt].SubItems.Add(item.BodyText);
                if (!item.Repeat & !item.AgainRepeat)
                {
                    ItemListView.Items[itemcnt].SubItems.Add(item.CreateTime.ToString("dd.MM.yyyy HH:mm:ss"));
                    ItemListView.Items[itemcnt].SubItems.Add(item.RunningTime.ToString("dd.MM.yyyy HH:mm:ss"));
                }
                else
                {
                    ItemListView.Items[itemcnt].SubItems.Add(item.CreateTime.ToString("dd.MM.yyyy HH:mm:ss"));
                    ItemListView.Items[itemcnt].SubItems.Add(item.RunningTime.ToString("HH:mm:ss"));
                }
                ItemListView.Items[itemcnt].SubItems.Add(((item.RunnerList==null) ? "0" : item.RunnerList.Length.ToString()));
                TimeSpan span = (item.RunningTime - DateTime.Now);
                bool finnish = item.Worked;
                string[] sprites = span.ToString().Split('.');
                ItemListView.Items[itemcnt].SubItems.Add(((!item.Repeat & !item.AgainRepeat & finnish) ? "Ýþlem Bitti" : span.ToString().Substring(0, span.ToString().Length - sprites[sprites.Length - 1].Length - 1)));
                ItemListView.Items[itemcnt].Tag = item;

                Color clr;
                if (!item.Repeat & !item.AgainRepeat & finnish) clr = Color.Violet;
                else clr = Color.Gainsboro;
                ItemListView.Items[itemcnt].SubItems[0].BackColor = clr;
                ItemListView.Items[itemcnt].SubItems[1].BackColor = clr;
                ItemListView.Items[itemcnt].SubItems[2].BackColor = clr;
                ItemListView.Items[itemcnt].SubItems[3].BackColor = clr;
                ItemListView.Items[itemcnt].SubItems[4].BackColor = clr;
                ItemListView.Items[itemcnt].SubItems[5].BackColor = clr;
                ItemListView.Items[itemcnt].SubItems[6].BackColor = clr;
                ItemListView.Items[itemcnt].SubItems[7].BackColor = clr;
            }
            return finding;
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GunlukEkle ekle = new GunlukEkle();
            if (ekle.ShowDialog() == DialogResult.OK)
            {
                itemList.Add(ekle.finnishItem);
                RefreshList();
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ItemListView.SelectedItems.Count <= 0) return;
            int select = ItemListView.SelectedItems[0].Index;
            if (select > -1)
            {
                GunlukEkle ekle = new GunlukEkle();
                ekle.SetSettings((Items.Item)ItemListView.Items[select].Tag);
                if (ekle.ShowDialog() == DialogResult.OK)
                {
                    itemList[select] = ekle.finnishItem;
                    RefreshList();
                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ItemListView.SelectedItems.Count <= 0) return;
            int select = ItemListView.SelectedItems[0].Index;
            DialogResult result = MessageBox.Show("Seçtiðiniz Ýþlemi silmek istediðinizden emin misiniz?", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            if (select > -1)
            {
                itemList.RemoveAt(select);

                RefreshList();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ItemListView.Items.Count; i++)
            {
                Items.Item item = (Items.Item)ItemListView.Items[i].Tag;
                TimeSpan span = (item.RunningTime - DateTime.Now);
                item.WorkingControl();
                if ((int)span.TotalSeconds < 0 && !item.Worked)
                {
                    item.Worked = true;
                    if (item.RunnerList != null)
                    {
                        foreach (Types.Runner runner in item.RunnerList)
                        {
                            runner.Run(item);
                        }
                    }
                }
                bool finnish = item.Worked;
                string[] sprites = span.ToString().Split('.');
                if (!item.Repeat & !item.AgainRepeat)
                {
                    ItemListView.Items[i].SubItems[5].Text = item.RunningTime.ToString("dd.MM.yyyy HH:mm:ss");
                }
                else
                {
                    ItemListView.Items[i].SubItems[5].Text = item.RunningTime.ToString("HH:mm:ss");
                }
                ItemListView.Items[i].SubItems[7].Text = ((!item.Repeat & !item.AgainRepeat & finnish) ? "Ýþlem Bitti" : span.ToString().Substring(0, span.ToString().Length - sprites[sprites.Length - 1].Length - 1));
                Color clr;
                if (!item.Repeat & !item.AgainRepeat & finnish) clr = Color.Violet;
                else clr = Color.Gainsboro;
                ItemListView.Items[i].SubItems[0].BackColor = clr;
                ItemListView.Items[i].SubItems[1].BackColor = clr;
                ItemListView.Items[i].SubItems[2].BackColor = clr;
                ItemListView.Items[i].SubItems[3].BackColor = clr;
                ItemListView.Items[i].SubItems[4].BackColor = clr;
                ItemListView.Items[i].SubItems[5].BackColor = clr;
                ItemListView.Items[i].SubItems[6].BackColor = clr;
                ItemListView.Items[i].SubItems[7].BackColor = clr;
            }
            if (this.WindowState == FormWindowState.Minimized && !notifyIcon1.Visible)
            {
                notifyIcon1.Visible = true;
                this.Hide();
                notifyIcon1.ShowBalloonTip(1);
            }
        }

        private void cýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }
}