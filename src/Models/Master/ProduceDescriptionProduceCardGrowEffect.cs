using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceDescriptionProduceCardGrowEffect
    {
        public ProduceCardGrowEffectType Type;                           // 24 enum
        public string                   Name;                           // 32
        public bool                     NoIcon;                         // 40
        public bool                     NoReference;                    // 41
        public string                   ProduceDescriptionLabelId;      // 48
        public string                   ProduceCardCustomizeDescription; // 56
    }
}
