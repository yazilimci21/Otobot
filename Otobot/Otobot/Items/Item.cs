using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Drawing;

namespace Items
{
    public class Item : XmlSerializer
    {
        public string Subject = "", Body = "", BodyText = "";
        public DateTime CreateTime = DateTime.Now, RunningTime = DateTime.Now.AddHours(1);
        public int AgainRunningSecond;
        public Types.Runner[] RunnerList;
        public Image image;
        public bool Repeat=false, AgainRepeat=false, Worked = true;

        public void WorkingControl()
        {
            if (!this.Worked)
            {
                if (this.RunningTime > DateTime.Now) this.Worked = false;
                return;
            }
            if (this.AgainRepeat)
                {
                    if (this.RunningTime < DateTime.Now)
                    {
                        this.RunningTime = DateTime.Now.AddSeconds(AgainRunningSecond);
                        return;
                    }
                }
            if (this.Repeat)
            {
                if (this.RunningTime < DateTime.Now)
                {
                    DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, this.RunningTime.Hour, this.RunningTime.Minute, this.RunningTime.Second);
                    this.RunningTime = dt.AddDays(1);
                }
            }
            return;
        }

        public Item() { }

        public bool Find(string find, int findType)
        {
            if (find == "" || find == String.Empty || find == null) return true;
            switch (findType)
            {
                case 0:
                    if (Subject.IndexOf(find) > -1) return true;
                    break;
                case 1:
                    if (BodyText.IndexOf(find) > -1) return true;
                    break;
                case 2:
                    if (CreateTime.ToString().IndexOf(find) > -1) return true;
                    break;
                case 3:
                    if (RunningTime.ToString().IndexOf(find) > -1) return true;
                    break;
                case 4:
                    if (Subject.IndexOf(find) > -1) return true;
                    if (BodyText.IndexOf(find) > -1) return true;
                    if (CreateTime.ToString().IndexOf(find) > -1) return true;
                    if (RunningTime.ToString().IndexOf(find) > -1) return true;
                    break;
            }
            return false;
        }

        public Item(string Subject, string Body, string BodyText, DateTime CreateTime, DateTime RunningTime, int AgainRunningSecond, bool Repeat, bool AgainRepeat, Types.Runner[] RunnerList)
        {
            this.Subject = Subject;
            this.Body = Body;
            this.BodyText = BodyText;
            this.CreateTime = CreateTime;
            this.RunningTime = ((!AgainRepeat) ? RunningTime : DateTime.Now.AddSeconds(AgainRunningSecond));
            this.Repeat = Repeat;
            this.AgainRepeat = AgainRepeat;
            this.AgainRunningSecond = AgainRunningSecond;
            if (this.RunningTime > DateTime.Now) this.Worked = false;
            this.RunnerList = RunnerList;
        }
    }
}
