using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class PvpRateMotion
    {
        public string                   CharacterId;                    // 24
        public PvpRateMotionType        MotionType;                     // 32 enum
        public int                      Number;                         // 36
        public string                   FacialAssetId;                  // 40
        public string                   BodyAssetId;                    // 48
        public string                   VoiceAssetId;                   // 56
        public string                   SceneLayoutId;                  // 64
        public string                   CameraId;                       // 72
    }
}
