using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceStepSelfLessonMotion
    {
        public string                   CharacterId;                    // 24
        public ProduceStepType          StepType;                       // 32 enum
        public int                      Number;                         // 36
        public string                   MotionAssetId;                  // 40
        public string                   VoiceAssetId;                   // 48
        public string                   BgmAssetId;                     // 56
        public string                   SceneLayoutId;                  // 64
        public string                   CameraId;                       // 72
        public string[]                 PropAssetIds;                   // 80
        public bool                     DisableLipSync;                 // 88
    }
}
