using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class UnlockTarget
    {
        public ProducerLevelUnlockType  Type;                           // 24 enum
        public string                   Id;                             // 32
        public int                      Quantity;                       // 40
    }
}
