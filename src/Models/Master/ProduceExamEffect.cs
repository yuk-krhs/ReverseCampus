using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceExamEffect
    {
        public string                   Id;                             // 24
        public ProduceExamEffectType    EffectType;                     // 32 enum
        public int                      EffectValue1;                   // 36
        public int                      EffectValue2;                   // 40
        public int                      EffectCount;                    // 44
        public int                      EffectTurn;                     // 48
        public string                   TargetProduceCardId;            // 56
        public int                      TargetUpgradeCount;             // 64
        public ProduceExamEffectType    TargetExamEffectType;           // 68 enum
        public string                   ProduceCardSearchId;            // 72
        public ProduceCardMovePositionType MovePositionType;               // 80 enum
        public ProducePickRangeType     PickRangeType;                  // 84 enum
        public int                      PickCountMin;                   // 88
        public int                      PickCountMax;                   // 92
        public string                   ChainProduceExamEffectId;       // 96
        public string                   ProduceExamStatusEnchantId;     // 104
        public string                   ProduceCardStatusEnchantId;     // 112
        public string[]                 ProduceCardGrowEffectIds;       // 120
        public string[]                 EffectGroupIds;                 // 128
        public ProduceDescriptionSegment[] ProduceDescriptions;            // 136
        public ProduceDescriptionSegment[] CustomizeProduceDescriptions;   // 144
    }
}
