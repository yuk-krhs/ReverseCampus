using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceCardGrowEffect
    {
        public string                   Id;                             // 24
        public ProduceCardGrowEffectType EffectType;                     // 32 enum
        public ExamCostType             CostType;                       // 36 enum
        public int                      Value;                          // 40
        public string                   PlayProduceExamTriggerId;       // 48
        public string                   PlayEffectProduceExamTriggerId; // 56
        public string[]                 TargetPlayEffectProduceExamTriggerIds; // 64
        public string                   PlayProduceExamEffectId;        // 72
        public string[]                 TargetPlayProduceExamEffectIds; // 80
        public string                   ProduceCardStatusEnchantId;     // 88
        public ProduceCardMovePositionType PlayMovePositionType;           // 96 enum
        public string[]                 EffectGroupIds;                 // 104
    }
}
