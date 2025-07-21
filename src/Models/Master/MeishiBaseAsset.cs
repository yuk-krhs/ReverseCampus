using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MeishiBaseAsset
    {
        public string                   Id;                             // 32
        public string                   Name;                           // 40
        public bool                     IsDefault;                      // 48
        public MeishiBaseAssetType      MeishiBaseAssetType;            // 52 enum
        public int                      Order;                          // 56
    }
}
