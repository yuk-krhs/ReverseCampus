using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceExamTrigger
    {
        public string                   Id;                             // 24
        public ProduceExamPhaseType[]   PhaseTypes;                     // 32
        public int[]                    PhaseValues;                    // 40
        public ProduceExamTriggerCheckType[] FieldStatusCheckTypes;          // 48
        public ProduceExamFieldStatusType[] FieldStatusTypes;               // 56
        public int[]                    FieldStatusValues;              // 64
        public string[]                 FieldStatusProduceCardSearchIds; // 72
        public string                   ProduceCardSearchId;            // 80
        public int                      UpperSearchCount;               // 88
        public int                      LowerSearchCount;               // 92
        public ProduceCardMovePositionType CardMovePositionType;           // 96 enum
        public ProduceExamEffectType[]  EffectTypes;                    // 104
        public ProduceStepLessonType    LessonType;                     // 112 enum
        public ProduceDescriptionSegment[] ProduceDescriptions;            // 120
        public ProduceDescriptionSegment[] PlayProduceDescriptions;        // 128
        public ProduceDescriptionSegment[] PlayEffectProduceDescriptions;  // 136
    }
}
