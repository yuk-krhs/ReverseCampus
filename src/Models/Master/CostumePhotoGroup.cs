using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class CostumePhotoGroup
    {
        public string                   Id;                             // 24
        public string                   CharacterId;                    // 32
        public int                      Number;                         // 40
        public string[]                 CostumeIds;                     // 48
    }
}
