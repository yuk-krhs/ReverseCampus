using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceResultMotion
    {
        public string                   CharacterId;                    // 24
        public ProduceLiveType          LiveType;                       // 32 enum
        public int                      Number;                         // 36
        public string                   MotionAssetId;                  // 40
        public string                   FacialAssetId;                  // 48
        public string                   VoiceAssetId;                   // 56
        public string[]                 ProduceGroupIds;                // 64
    }
}
