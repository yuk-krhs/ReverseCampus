using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceDescriptionSegment
    {
        public ProduceDescriptionType   ProduceDescriptionType;         // 24 enum
        public ExamDescriptionType      ExamDescriptionType;            // 28 enum
        public ProduceExamEffectType    ExamEffectType;                 // 32 enum
        public ProduceCardGrowEffectType ProduceCardGrowEffectType;      // 36 enum
        public ProduceCardCategory      ProduceCardCategory;            // 40 enum
        public ProduceCardMovePositionType ProduceCardMovePositionType;    // 44 enum
        public ProduceStepType          ProduceStepType;                // 48 enum
        public string                   Text;                           // 56
        public string                   TargetId;                       // 64
        public int                      TargetLevel;                    // 72
        public int                      EffectValue1;                   // 76
        public int                      EffectValue2;                   // 80
        public int                      EffectCount;                    // 84
        public int                      Turn;                           // 88
        public int                      CostValue;                      // 92
        public string                   ProduceDescriptionSwapId;       // 96
        public string                   OriginProduceExamTriggerId;     // 104
        public string                   OriginProduceExamEffectId;      // 112
        public string                   OriginProduceCardStatusEnchantId; // 120
        public bool                     IsCost;                         // 128
        public bool                     IsOnlyOutGame;                  // 129
        public bool                     ChangeColor;                    // 130
        public bool                     IsCustomized;                   // 131
    }
}
