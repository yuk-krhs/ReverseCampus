using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MissionPointRewardSet
    {
        public string                   MissionPointId;                 // 24
        public int                      Point;                          // 32
        public bool                     IsFeature;                      // 36
        public Reward[]                 Rewards;                        // 40
    }
}
