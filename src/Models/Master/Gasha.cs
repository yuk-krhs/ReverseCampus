using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Gasha
    {
        public string                   Id;                             // 24
        public string                   BannerAssetId;                  // 32
        public bool                     HasFixReward;                   // 40
        public string                   ViewConditionSetId;             // 48
        public string                   UnlockConditionSetId;           // 56
        public long                     StartTime;                      // 64
        public long                     EndTime;                        // 72
    }
}
