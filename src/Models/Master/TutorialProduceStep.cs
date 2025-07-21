using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class TutorialProduceStep
    {
        public TutorialType             TutorialType;                   // 24 enum
        public string                   IdolCardId;                     // 32
        public int                      StepNumber;                     // 40
        public int                      TutorialStep;                   // 44
        public ProduceStepType          StepType;                       // 48 enum
        public string                   Name;                           // 56
        public bool                     ProduceStepRefresh;             // 64
        public string                   ProduceStepLessonId;            // 72
        public int                      ProgressLevel;                  // 80
        public int                      ProduceNavigationNumber;        // 84
        public int                      RankThreshold;                  // 88
        public int                      ParameterBaseLine;              // 92
        public int                      BaseScore;                      // 96
        public int                      ForceEndScore;                  // 100
        public string                   ProduceExamBattleNpcGroupId;    // 104
        public string                   ProduceExamBattleConfigId;      // 112
        public string                   ProduceExamGimmickEffectGroupId; // 120
    }
}
