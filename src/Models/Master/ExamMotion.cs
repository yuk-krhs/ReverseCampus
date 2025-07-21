using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ExamMotion
    {
        public string                   CharacterId;                    // 24
        public ExamMotionTargetType     Type;                           // 32 enum
        public ExamMotionType           MotionType;                     // 36 enum
        public int                      Number;                         // 40
        public string                   FacialMotionId;                 // 48
        public string                   BodyMotionId;                   // 56
        public string                   VoiceAssetId;                   // 64
        public string                   SceneLayoutId;                  // 72
        public string                   CameraId;                       // 80
        public string[]                 ProduceGroupIds;                // 88
    }
}
