using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class DearnessMotion
    {
        public string                   CharacterId;                    // 24
        public DearnessMotionType       MotionType;                     // 32 enum
        public int                      Number;                         // 36
        public string                   ConditionSetId;                 // 40
        public string[]                 FacialAssetIds;                 // 48
        public string[]                 BodyAssetIds;                   // 56
        public string                   VoiceAssetId;                   // 64
        public string                   CostumeId;                      // 72
        public string                   CostumeHeadId;                  // 80
        public bool                     IsPrioritized;                  // 88
    }
}
