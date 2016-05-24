using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public class Runner : XmlSerializer
    {
        public virtual bool Run(Items.Item item) { return true; }
        public virtual bool Create() { return true; }
        public string Name="";
        public string Description="";
    }
}
