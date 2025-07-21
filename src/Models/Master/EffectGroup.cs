using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class EffectGroup
    {
        public string                   Id;                             // 24
        public string                   Name;                           // 32
        public ProduceExamEffectType    ExamEffectType;                 // 40 enum
        public ProduceEffectType        ProduceEffectType;              // 44 enum
        public ProduceExamEffectType[]  ExamEffectTypes;                // 48
        public ProduceEffectType[]      ProduceEffectTypes;             // 56
        public bool                     HiddenFilter;                   // 64
        public ProduceCardGrowEffectType[] ProduceCardGrowEffectTypes;     // 72
        public int                      Order;                          // 80
    }
}
