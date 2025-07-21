using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class PhotoPose
    {
        public string                   Id;                             // 24
        public string                   PhotoBackgroundId;              // 32
        public int[]                    CameraNumbers;                  // 40
        public int[]                    PositionNumbers;                // 48
        public string                   CharacterId;                    // 56
        public PhotoPoseMotionType      MotionType;                     // 64 enum
        public string                   Name;                           // 72
        public PhotoLookTargetType      LookTargetType;                 // 80 enum
        public bool                     DisableLookTargetIdol;          // 84
        public string[]                 MotionAssetIds;                 // 88
        public string[]                 FacialAssetIds;                 // 96
        public string[]                 PropAssetIds;                   // 104
        public string                   PhotoReactionVoiceGroupId;      // 112
        public string                   PhotoWaitVoiceGroupId;          // 120
        public string                   PhotoFacialMotionGroupId;       // 128
        public string                   ViewConditionSetId;             // 136
        public string                   UnlockConditionSetId;           // 144
        public int                      Order;                          // 152
    }
}
