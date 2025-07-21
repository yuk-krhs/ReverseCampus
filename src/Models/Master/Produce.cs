using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Produce
    {
        public string                   Id;                             // 32
        public string                   Name;                           // 40
        public int                      BaseStepLevel;                  // 48
        public int                      MaxRefreshCount;                // 52
        public string                   ChallengeViewConditionSetId;    // 56
        public string                   ViewConditionSetId;             // 64
        public string                   UnlockConditionSetId;           // 72
        public string                   ExamSettingId;                  // 80
        public string                   ProduceSettingId;               // 88
        public int                      IdolCardParameterGrowthLimit;   // 96
        public int                      MaxProduceEventCharacterGrowthNumber; // 100
        public int                      Steps;                          // 104
        public int                      ActionPointQuantity;            // 108
        public string                   AssetId;                        // 112
        public string                   ProduceNavigationNormalId;      // 120
        public string                   ProduceNavigationAuditionId;    // 128
        public string                   ProduceNavigationLoseId;        // 136
        public string                   GradientColor1;                 // 144
        public string                   GradientColor2;                 // 152
        public int                      Order;                          // 160
    }
}
