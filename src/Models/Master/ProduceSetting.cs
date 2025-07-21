using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceSetting
    {
        public string                   Id;                             // 24
        public int                      InitialProducePoint;            // 32
        public int                      ProduceDrinkPossessLimit;       // 36
        public int                      RefreshStaminaRecoveryPermil;   // 40
        public int                      CustomizeProduceCardCount;      // 44
        public int                      StepSkipStaminaRecoveryPermil;  // 48
        public int                      BeforeAuditionRefreshStaminaRecoveryPermil; // 52
        public int                      StepCustomizeStartAlertProducePointThreshold; // 56
        public int                      ExamStartAlertStaminaThreshold; // 60
        public int                      ContinueCount;                  // 64
        public int                      ProduceAuditionTrendAssessmentPermil; // 68
    }
}
