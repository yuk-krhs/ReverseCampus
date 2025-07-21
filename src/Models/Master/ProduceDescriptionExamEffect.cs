using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceDescriptionExamEffect
    {
        public ProduceExamEffectType    Type;                           // 24 enum
        public string                   Name;                           // 32
        public string                   ProduceDescriptionSwapId;       // 40
        public string                   ProduceDescriptionLabelId;      // 48
        public string                   ExamProduceDescriptionLabelId;  // 56
        public int[]                    MainBuffMinThresholds;          // 64
        public bool                     NoIcon;                         // 72
        public bool                     NoReference;                    // 73
    }
}
