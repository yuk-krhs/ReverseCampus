using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class SupportCardFlavor
    {
        public string                   SupportCardId;                  // 24
        public int                      Number;                         // 32
        public string[]                 CharacterIds;                   // 40
        public string                   Text;                           // 48
        public string                   VoiceAssetId;                   // 56
    }
}
