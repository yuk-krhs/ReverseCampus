using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ExamOutGameMotion
    {
        public string                   CharacterId;                    // 24
        public ExamMotionTargetType     Type;                           // 32 enum
        public ExamOutGameMotionType    MotionType;                     // 36 enum
        public int                      Number;                         // 40
        public string[]                 FacialAssetIds;                 // 48
        public string[]                 BodyAssetIds;                   // 56
        public string                   VoiceAssetId;                   // 64
        public string                   SceneLayoutId;                  // 72
        public string                   CameraId;                       // 80
    }
}
