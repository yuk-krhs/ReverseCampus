using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceStepFanPresentMotion
    {
        public string                   CharacterId;                    // 24
        public ProduceStepFanPresentMotionType MotionType;                     // 32 enum
        public int                      Number;                         // 36
        public string[]                 FacialAssetIds;                 // 40
        public string[]                 BodyAssetIds;                   // 48
        public string                   VoiceAssetId;                   // 56
    }
}
