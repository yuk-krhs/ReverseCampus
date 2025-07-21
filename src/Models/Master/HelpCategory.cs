using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class HelpCategory
    {
        public string                   Id;                             // 24
        public string                   Name;                           // 32
        public string[]                 AssetIds;                       // 40
        public string[]                 Texts;                          // 48
        public bool                     HiddenHelpList;                 // 56
        public int                      Order;                          // 60
    }
}
