using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceStepTransition
    {
        public string                   CharacterId;                    // 32
        public ProduceStepType          StepType;                       // 40 enum
        public ProduceStepPhaseType     StepPhaseType;                  // 44 enum
        public int                      Number;                         // 48
        public string                   CostumeHeadId;                  // 56
        public string                   CostumeId;                      // 64
        public string                   AdvAssetId;                     // 72
        public string                   VoiceAssetId;                   // 80
        public string                   ProduceGroupId;                 // 88
    }
}
