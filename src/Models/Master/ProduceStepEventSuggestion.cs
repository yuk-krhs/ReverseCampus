using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceStepEventSuggestion
    {
        public string                   Id;                             // 24
        public int                      ProducePoint;                   // 32
        public int                      Stamina;                        // 36
        public string                   ProduceCardId;                  // 40
        public int                      ProduceCardUpgradeCount;        // 48
        public string[]                 ProduceEffectIds;               // 56
        public ProduceStepType          StepType;                       // 64 enum
        public string                   StepId;                         // 72
        public int                      SuccessProbabilityPermyriad;    // 80
        public string[]                 SuccessProduceEffectIds;        // 88
        public ProduceStepType          SuccessStepType;                // 96 enum
        public string                   SuccessStepId;                  // 104
        public string[]                 FailProduceEffectIds;           // 112
        public ProduceStepType          FailStepType;                   // 120 enum
        public string                   FailStepId;                     // 128
        public bool                     AlwaysSuccessful;               // 136
        public int                      ProduceEffectFireStep;          // 140
        public bool                     IsCampaign;                     // 144
        public ProduceDescriptionSegment[] ProduceDescriptions;            // 152
    }
}
