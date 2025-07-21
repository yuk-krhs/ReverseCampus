using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceCard
    {
        public string                   Id;                             // 24
        public int                      UpgradeCount;                   // 32
        public ProduceCardCustomize[]   Customizes;                     // 40
    }
}
