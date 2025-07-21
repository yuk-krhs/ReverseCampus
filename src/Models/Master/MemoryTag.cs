using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MemoryTag
    {
        public string                   Id;                             // 32
        public string                   DefaultName;                    // 40
        public string                   AssetId;                        // 48
        public int                      Order;                          // 56
    }
}
