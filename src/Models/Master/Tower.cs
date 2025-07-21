using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Tower
    {
        public string                   Id;                             // 24
        public string                   CharacterId;                    // 32
        public string                   Title;                          // 40
        public string                   ViewConditionSetId;             // 48
        public string                   UnlockConditionSetId;           // 56
        public string                   AchievementId;                  // 64
        public int                      Order;                          // 72
    }
}
