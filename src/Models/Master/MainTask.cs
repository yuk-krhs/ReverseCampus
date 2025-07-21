using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MainTask
    {
        public string                   MainTaskGroupId;                // 24
        public int                      Number;                         // 32
        public string                   Title;                          // 40
        public string                   Description;                    // 48
        public string                   HomeDescription;                // 56
        public MissionType              MissionType;                    // 64 enum
        public string[]                 TargetIds1;                     // 72
        public string[]                 TargetIds2;                     // 80
        public string[]                 TargetIds3;                     // 88
        public int                      TargetValue;                    // 96
        public string                   MissionId;                      // 104
        public int                      Threshold;                      // 112
        public string                   ViewConditionSetId;             // 120
        public string                   UnlockConditionSetId;           // 128
        public Reward[]                 Rewards;                        // 136
        public Reward[]                 AdditionalRewards;              // 144
        public TutorialType             UnlockFeatureTutorialType;      // 152 enum
    }
}
