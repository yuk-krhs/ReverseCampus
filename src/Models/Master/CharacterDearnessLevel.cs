using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class CharacterDearnessLevel
    {
        public string                   CharacterId;                    // 32
        public int                      DearnessLevel;                  // 40
        public string                   AdvAssetId;                     // 48
        public string                   StoryId;                        // 56
        public string                   ProduceConditionDescription;    // 64
        public string                   ProduceConditionAchievementId;  // 72
        public int                      ProduceConditionAchievementThreshold; // 80
        public ProduceSkill[]           ProduceSkills;                  // 88
        public Reward[]                 Rewards;                        // 96
        public bool                     IgnoreReport;                   // 104
        public string                   ItemUnlockConditionSetId;       // 112
        public bool                     IsStepThresholdLevel;           // 120
        public bool                     IsTargetLevel;                  // 121
        public string                   TargetDescription;              // 128
        public ProduceType              TrueEndAchievementProduceType;  // 136 enum
        public int                      DearnessPointThreshold;         // 140
    }
}
