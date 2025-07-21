using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceReward
    {
        public ProduceResourceType      ResourceType;                   // 24 enum
        public string                   ResourceId;                     // 32
        public int                      ResourceLevel;                  // 40
    }
}
