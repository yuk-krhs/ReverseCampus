using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class PhotoFacialMotionGroup
    {
        public string                   Id;                             // 24
        public int                      Number;                         // 32
        public string                   FacialAssetId;                  // 40
        public string                   Name;                           // 48
        public bool                     DisableAutoBlink;               // 56
    }
}
