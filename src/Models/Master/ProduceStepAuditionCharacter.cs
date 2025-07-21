using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceStepAuditionCharacter
    {
        public string                   CharacterId;                    // 24
        public ProduceStepType          StepType;                       // 32 enum
        public int                      Number;                         // 36
        public int                      SuccessNextIdolAuditionRank;    // 40
        public int                      FailureNextIdolAuditionRank;    // 44
        public string                   AuditionSelectHeaderSilhouetteAssetId; // 48
    }
}
