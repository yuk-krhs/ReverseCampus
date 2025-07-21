using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MissionPass
    {
        public string                   Id;                             // 24
        public string                   Name;                           // 32
        public string                   Description;                    // 40
        public string                   AssetId;                        // 48
        public string                   MissionPassPointId;             // 56
        public string                   PremiumPassShopItemId;          // 64
        public string                   ViewConditionSetId;             // 72
        public string                   UnlockConditionSetId;           // 80
        public long                     StartTime;                      // 88
        public long                     EndTime;                        // 96
        public int                      Order;                          // 104
    }
}
