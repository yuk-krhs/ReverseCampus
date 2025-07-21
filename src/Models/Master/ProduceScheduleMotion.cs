using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceScheduleMotion
    {
        public string                   CharacterId;                    // 24
        public ProduceScheduleLocationType LocationType;                   // 32 enum
        public ProduceScheduleStaminaMotionType StaminaMotionType;              // 36 enum
        public ProduceScheduleMotionType MotionType;                     // 40 enum
        public int                      Number;                         // 44
        public string[]                 FacialAssetIds;                 // 48
        public string[]                 BodyAssetIds;                   // 56
        public string                   VoiceAssetId;                   // 64
    }
}
