using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class AppReview
    {
        public AppReviewType            Type;                           // 24 enum
        public string                   ConditionSetId;                 // 32
        public string                   GashaId;                        // 40
        public string                   MainTaskGroupId;                // 48
        public int                      MainTaskNumber;                 // 56
        public string                   AchievementId;                  // 64
        public int                      AchievementProgressThreshold;   // 72
        public string                   ProduceId;                      // 80
    }
}
