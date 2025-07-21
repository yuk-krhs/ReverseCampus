using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceItem
    {
        public string                   Id;                             // 24
        public string                   AssetId;                        // 32
        public ProduceItemRarity        Rarity;                         // 40 enum
        public string                   Name;                           // 48
        public ProducePlanType          PlanType;                       // 56 enum
        public int                      FireLimit;                      // 60
        public int                      FireInterval;                   // 64
        public string                   ProduceTriggerId;               // 72
        public string[]                 ProduceTriggerIds;              // 80
        public string[]                 ProduceItemEffectIds;           // 88
        public Skill[]                  Skills;                         // 96
        public bool                     LibraryHidden;                  // 104
        public ProduceDescriptionSegment[] ProduceDescriptions;            // 112
        public int                      Evaluation;                     // 120
        public bool                     IsExamEffect;                   // 124
        public string                   OriginIdolCardId;               // 128
        public string                   OriginSupportCardId;            // 136
        public bool                     IsUpgraded;                     // 144
        public string[]                 EffectGroupIds;                 // 152
        public bool                     IsChallenge;                    // 160
        public bool                     IsHighScoreRush;                // 161
        public long                     ViewStartTime;                  // 168
        public bool                     IsLimited;                      // 176
        public long                     Order;                          // 184
    }
}
