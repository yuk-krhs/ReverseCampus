using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceItemEffect
    {
        public string                   Id;                             // 24
        public ProduceItemEffectType    EffectType;                     // 32 enum
        public int                      EffectTurn;                     // 36
        public int                      EffectCount;                    // 40
        public string                   ProduceEffectId;                // 48
        public string                   ProduceExamStatusEnchantId;     // 56
    }
}
