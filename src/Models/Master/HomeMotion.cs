using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class HomeMotion
    {
        public string                   CharacterId;                    // 24
        public HomeLocationType         LocationType;                   // 32 enum
        public HomeMotionType           MotionType;                     // 36 enum
        public int                      Number;                         // 40
        public string                   ConditionSetId;                 // 48
        public string[]                 FacialAssetIds;                 // 56
        public string[]                 BodyAssetIds;                   // 64
        public string                   VoiceAssetId;                   // 72
        public bool                     IsPrioritized;                  // 80
    }
}
