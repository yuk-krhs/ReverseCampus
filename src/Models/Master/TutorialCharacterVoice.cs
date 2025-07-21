using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class TutorialCharacterVoice
    {
        public string                   CharacterId;                    // 24
        public TutorialCharacterVoiceType Type;                           // 32 enum
        public int                      Number;                         // 36
        public string                   AssetId;                        // 40
    }
}
