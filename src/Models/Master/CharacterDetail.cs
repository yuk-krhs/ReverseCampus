using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class CharacterDetail
    {
        public string                   CharacterId;                    // 24
        public CharacterDetailType      Type;                           // 32 enum
        public string                   Content;                        // 40
        public int                      Order;                          // 48
    }
}
