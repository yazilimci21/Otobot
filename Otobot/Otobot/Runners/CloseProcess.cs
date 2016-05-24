using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Otobot.Runners
{
    class CloseProcess : Types.Runner
    {
        public int processId;
        public IntPtr processHandle;
        public string processName;

        public CloseProcess()
        {
            Name = "CloseProcess";
            Description = "Bir programý kapatmanýza yarayan çalýþtýrýcý";
        }

        public override bool Create()
        {
            CloseProcessStart close = new CloseProcessStart();
            if (close.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (close.processName != "")
                {
                    processName = close.processName;
                }
                else
                {
                    this.processHandle = close.processHandle;
                    this.processId = close.processId;
                }
                return true;
            }
            return false;
        }

        public override bool Run(Items.Item item)
        {
            try
            {
                if (processName == "")
                {
                    Process proc = Process.GetProcessById(processId);
                    proc.Kill();
                }
                else
                {
                    foreach(Process proc in Process.GetProcessesByName(processName))
                    {
                        proc.Kill();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
