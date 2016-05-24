using System;
using System.Collections.Generic;
using System.Text;

namespace Items
{
    class ItemList : XmlSerializer
    {
        public Item[] Items;
        public string GroupName;
    }
}
