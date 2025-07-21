using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class WorkLevelReward
    {
        public WorkType                 Type;                           // 24 enum
        public int                      DurationMinutes;                // 28
        public int                      Level;                          // 32
        public int                      DearnessLevel;                  // 36
        public int                      RewardQuantity;                 // 40
        public int                      MoneyRewardQuantity;            // 44
        public int                      FanRewardQuantity;              // 48
    }
}
