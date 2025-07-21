using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceEffect
    {
        public string                   Id;                             // 24
        public ProduceEffectType        ProduceEffectType;              // 32 enum
        public int                      EffectValueMin;                 // 36
        public int                      EffectValueMax;                 // 40
        public ProduceResourceType      ProduceResourceType;            // 44 enum
        public ProduceReward[]          ProduceRewards;                 // 48
        public string                   ProduceCardSearchId;            // 56
        public string                   ProduceExamStatusEnchantId;     // 64
        public string                   ProduceStepEventDetailId;       // 72
        public ProducePickRangeType     PickRangeType;                  // 80 enum
        public int                      PickCountMin;                   // 84
        public int                      PickCountMax;                   // 88
    }
}
