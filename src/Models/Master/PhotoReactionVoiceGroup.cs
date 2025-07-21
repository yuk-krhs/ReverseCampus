using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class PhotoReactionVoiceGroup
    {
        public string                   Id;                             // 24
        public int                      Number;                         // 32
        public string                   PoseVoiceAssetId;               // 40
        public int                      PoseVoiceDelayMilliseconds;     // 48
        public string                   ReactionVoiceAssetId;           // 56
        public int                      ReactionVoiceDelayMilliseconds; // 64
    }
}
