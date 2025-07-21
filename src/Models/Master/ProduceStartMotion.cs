using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceStartMotion
    {
        public string                   CharacterId;                    // 24
        public ProduceStartMotionType   MotionType;                     // 32 enum
        public int                      Number;                         // 36
        public string                   MotionAssetId;                  // 40
        public string                   FacialAssetId;                  // 48
        public string                   VoiceAssetId;                   // 56
    }
}
