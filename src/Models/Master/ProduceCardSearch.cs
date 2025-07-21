using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceCardSearch
    {
        public string                   Id;                             // 24
        public ProduceCardRarity[]      CardRarities;                   // 32
        public string[]                 ProduceCardIds;                 // 40
        public int[]                    UpgradeCounts;                  // 48
        public ProducePlanType          PlanType;                       // 56 enum
        public ProduceCardCategory[]    CardCategories;                 // 64
        public ProduceCardSearchStatusType CardStatusType;                 // 72 enum
        public ProduceCardOrderType     OrderType;                      // 76 enum
        public ProduceCardPositionType  CardPositionType;               // 80 enum
        public string                   CardSearchTag;                  // 88
        public string                   ProduceCardRandomPoolId;        // 96
        public int                      LimitCount;                     // 104
        public ConditionMinMaxType      StaminaMinMaxType;              // 108 enum
        public int                      StaminaMin;                     // 112
        public int                      StaminaMax;                     // 116
        public ProduceExamEffectType    ExamEffectType;                 // 120 enum
        public string[]                 EffectGroupIds;                 // 128
        public bool                     IsSelf;                         // 136
        public ProduceDescriptionSegment[] ProduceDescriptions;            // 144
        public string                   ProduceCardPoolId;              // 152
    }
}
