using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Mission
    {
        public string                   Id;                             // 24
        public string                   MissionGroupId;                 // 32
        public string                   Name;                           // 40
        public MissionCategory          Category;                       // 48 enum
        public MissionType              Type;                           // 52 enum
        public string[]                 TargetIds1;                     // 56
        public string[]                 TargetIds2;                     // 64
        public string[]                 TargetIds3;                     // 72
        public int                      TargetValue;                    // 80
        public bool                     IsLessThanTargetValue;          // 84
        public bool                     IsEventMission;                 // 85
        public string                   MissionDailyReleaseGroupId;     // 88
        public int                      MissionDailyReleaseDay;         // 96
        public string                   ViewConditionSetId;             // 104
        public string                   UnlockConditionSetId;           // 112
        public int                      Order;                          // 120
    }
}
