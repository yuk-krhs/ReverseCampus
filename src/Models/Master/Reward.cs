using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Reward
    {
        public ResourceType             ResourceType;                   // 24 enum
        public string                   ResourceId;                     // 32
        public int                      Quantity;                       // 40
        public string                   NameCache;                      // 48 Campus.Common.Data.ICommonResourceData.NameCache
        public string                   DescriptionCache;               // 56 Campus.Common.Data.ICommonResourceData.DescriptionCache
        public RarityType?              RarityTypeCache;                // 64 enum
    }
}
