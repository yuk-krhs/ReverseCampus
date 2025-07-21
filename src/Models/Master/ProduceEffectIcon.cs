using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceEffectIcon
    {
        public ProduceEffectType        Type;                           // 24 enum
        public ProduceResourceType      ResourceType;                   // 28 enum
        public string                   IconAssetId;                    // 32
        public string                   BackgroundAssetId;              // 40
        public long                     Order;                          // 48
    }
}
