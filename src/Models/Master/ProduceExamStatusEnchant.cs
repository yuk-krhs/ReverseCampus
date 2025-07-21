using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceExamStatusEnchant
    {
        public string                   Id;                             // 24
        public string                   AssetId;                        // 32
        public ProduceDescriptionSegment[] ProduceDescriptions;            // 40
        public string                   ProduceExamTriggerId;           // 48
        public string[]                 ProduceExamEffectIds;           // 56
    }
}
