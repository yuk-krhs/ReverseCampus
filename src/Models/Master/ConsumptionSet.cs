using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ConsumptionSet
    {
        public string                   Id;                             // 24
        public int                      Number;                         // 32
        public ResourceType             ResourceType;                   // 36 enum
        public string                   ResourceId;                     // 40
        public int                      Quantity;                       // 48
    }
}
