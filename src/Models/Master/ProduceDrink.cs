using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceDrink
    {
        public string                   Id;                             // 24
        public string                   AssetId;                        // 32
        public string                   Name;                           // 40
        public ProducePlanType          PlanType;                       // 48 enum
        public string[]                 ProduceDrinkEffectIds;          // 56
        public ProduceDrinkRarity       Rarity;                         // 64 enum
        public ProduceDescriptionSegment[] ProduceDescriptions;            // 72
        public int                      UnlockProducerLevel;            // 80
        public string[]                 EffectGroupIds;                 // 88
        public string                   OriginSupportCardId;            // 96
        public bool                     LibraryHidden;                  // 104
        public long                     ViewStartTime;                  // 112
        public long                     Order;                          // 120
    }
}
