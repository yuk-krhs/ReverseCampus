using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceStepAuditionDifficulty
    {
        public string                   Id;                             // 24
        public string                   ProduceId;                      // 32
        public ProduceStepType          StepType;                       // 40 enum
        public int                      Number;                         // 44
        public int                      RankThreshold;                  // 48
        public int                      ParameterBaseLine;              // 52
        public int                      BaseScore;                      // 56
        public int                      ForceEndScore;                  // 60
        public string                   ProduceExamBattleNpcGroupId;    // 64
        public string                   ProduceExamBattleConfigId;      // 72
        public string                   ProduceExamGimmickEffectGroupId; // 80
        public ProduceStepAuditionType  AuditionType;                   // 88 enum
        public bool                     IsUnlockAnimation;              // 92
        public int                      VoteCountBaseLine;              // 96
        public int                      DearnessLevel;                  // 100
        public int                      VoteCount;                      // 104
    }
}
