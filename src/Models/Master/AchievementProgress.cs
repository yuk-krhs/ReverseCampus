using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class AchievementProgress
    {
        public string                   AchievementId;                  // 24
        public int                      Threshold;                      // 32
        public string                   AssetId;                        // 40
        public Reward[]                 Rewards;                        // 48
        public int                      Index;                          // 56
    }
}
