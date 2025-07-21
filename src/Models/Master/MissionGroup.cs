using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MissionGroup
    {
        public string                   Id;                             // 24
        public string                   Name;                           // 32
        public string                   AssetId;                        // 40
        public string                   MissionPointId;                 // 48
        public string[]                 MissionIds;                     // 56
        public Reward[]                 Rewards;                        // 64
        public bool                     ShowHomeLimitedMission;         // 72
        public string                   RewardName;                     // 80
        public string                   RewardAssetId;                  // 88
        public string                   ConditionSetId;                 // 96
        public int                      Order;                          // 104
    }
}
