using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Otobot.Runners
{
    class OpenProcess : Types.Runner
    {
        public Process process;

        public OpenProcess()
        {
            Name = "OpenProcess";
            Description = "Bir programý çalýþtýrmanýza yarayan çalýþtýrýcý";
        }

        public override bool Create()
        {
            OpenProcessStart start = new OpenProcessStart();
            if (start.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                process = start.process;
                return true;
            }
            return false;
        }

        public override bool Run(Items.Item item)
        {
            try
            {
                process.Start();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
