using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceCardStatusEnchant
    {
        public string                   Id;                             // 24
        public string                   ProduceExamTriggerId;           // 32
        public string[]                 ProduceCardGrowEffectIds;       // 40
        public int                      TriggerCount;                   // 48
        public ProduceDescriptionSegment[] ProduceDescriptions;            // 56
        public string[]                 EffectGroupIds;                 // 64
    }
}
