using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class LoginBonusMotion
    {
        public string                   Id;                             // 24
        public int                      Order;                          // 32
        public int                      Number;                         // 36
        public string[]                 FacialAssetIds;                 // 40
        public string[]                 MotionAssetIds;                 // 48
        public string[]                 VoiceAssetIds;                  // 56
    }
}
