using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class SeminarExamTransition
    {
        public ProduceExamEffectType    ExamEffectType;                 // 24 enum
        public int                      IsLessonInt;                    // 28
        public string                   Description;                    // 32
        public string                   SeminarExamGroupId;             // 40
        public string                   SeminarExamId;                  // 48
        public string                   SeminarExamGroupName;           // 56
        public string                   SeminarExamName;                // 64
        public string[]                 ProduceIds;                     // 72
        public Reward[]                 Rewards;                        // 80
    }
}
