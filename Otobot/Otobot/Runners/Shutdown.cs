using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Otobot.Runners
{
    class Shutdown : Types.Runner
    {
        [DllImport("user32.dll")]
        public static extern int ExitWindowsEx(int operationFlag, int operationReason);
        public int ExitType = -1;

        public Shutdown()
        {
            Name = "ShutDown";
            Description = "Bilgisayarý Kapatmanýza yarayan çalýþtýrýcý";
        }

        public override bool Create()
        {
            ShutdownStart start = new ShutdownStart();
            if (start.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ExitType = start.ExitType;
                return true;
            }
            return false;
        }

        public override bool Run(Items.Item item)
        {
            try
            {
                ExitWindowsEx(ExitType, 0);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
