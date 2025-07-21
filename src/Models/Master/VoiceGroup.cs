using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class VoiceGroup
    {
        public string                   Id;                             // 24
        public string                   VoiceAssetId;                   // 32
        public string                   Title;                          // 40
        public string                   FacialAssetId;                  // 48
        public string                   BodyAssetId;                    // 56
        public int                      Order;                          // 64
    }
}
