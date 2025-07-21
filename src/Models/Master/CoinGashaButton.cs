using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class CoinGashaButton
    {
        public string                   Id;                             // 24
        public string                   Name;                           // 32
        public string                   Description;                    // 40
        public ResourceType             ResourceType;                   // 48 enum
        public string                   ResourceId;                     // 56
        public int                      Quantity;                       // 64
        public int                      MaxDrawCount;                   // 68
    }
}
