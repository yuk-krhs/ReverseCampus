using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class VoiceRoster
    {
        public string                   CharacterId;                    // 24
        public string                   AssetId;                        // 32
        public string                   Title;                          // 40
        public VoicePlayScreenType      Type;                           // 48 enum
        public string                   ConditionSetId;                 // 56
        public string                   ProduceGroupId;                 // 64
        public int                      Order;                          // 72
    }
}
