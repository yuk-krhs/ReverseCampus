using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceCharacterAdv
    {
        public ProduceType              ProduceType;                    // 32 enum
        public ProduceAdvType           Type;                           // 36 enum
        public string                   CharacterId;                    // 40
        public string                   Title;                          // 48
        public string                   AssetId;                        // 56
    }
}
