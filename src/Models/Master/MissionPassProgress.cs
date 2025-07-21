using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MissionPassProgress
    {
        public string                   MissionPassId;                  // 24
        public int                      Threshold;                      // 32
        public Reward                   NormalReward;                   // 40 class
        public Reward                   PremiumReward;                  // 48 class
        public bool                     Feature;                        // 56
        public bool                     Repeat;                         // 57
        public int                      RepeatPoint;                    // 60
    }
}
