using System;
using System.Collections.Generic;
using System.Text;

namespace Otobot.Runners
{
    class Reminder : Types.Runner
    {
        public int volume;
        public string file;

        public Reminder()
        {
            Name = "Reminder";
            Description = "Hatýrlatma eklemenize yarayan çalýþtýrýcý";
        }

        public override bool Create()
        {
            ReminderStart start = new ReminderStart();
            if (start.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.volume = start.volume;
                this.file = start.file;
                return true;
            }
            return false;
        }

        public override bool Run(Items.Item item)
        {
            try
            {
                ReminderRun run = new ReminderRun();
                run.Subject.Text = item.Subject;
                run.Body.Rtf = Encoding.Default.GetString(Convert.FromBase64String(item.Body));
                run.volume = this.volume;
                run.file = this.file;
                run.Show();
                return true;
            }
            catch { return false; }
        }
    }
}
