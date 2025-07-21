using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceStepAuditionMotion
    {
        public string                   CharacterId;                    // 24
        public ProduceStepType          StepType;                       // 32 enum
        public ProduceStepAuditionMotionType MotionType;                     // 36 enum
        public int                      Number;                         // 40
        public string                   FacialAssetId;                  // 48
        public string                   BodyAssetId;                    // 56
        public string                   VoiceAssetId;                   // 64
        public string                   SceneLayoutId;                  // 72
        public string                   CameraId;                       // 80
        public string[]                 ProduceGroupIds;                // 88
        public ProduceStepAuditionType  AuditionType;                   // 96 enum
    }
}
