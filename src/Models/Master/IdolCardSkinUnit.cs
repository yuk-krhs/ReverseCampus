using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class IdolCardSkinUnit
    {
        public string                   Id;                             // 24
        public string[]                 IdolCardSkinIds;                // 32
        public UnitCharacter[]          UnitCharacters;                 // 40
        public string[]                 LiveOrderCharacterIds;          // 48
    }
}
