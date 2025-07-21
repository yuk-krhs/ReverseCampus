using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class SupportCard
    {
        public string                   Id;                             // 32
        public string[]                 CharacterIds;                   // 40
        public string                   Name;                           // 48
        public SupportCardType          Type;                           // 56 enum
        public ProducePlanType          PlanType;                       // 60 enum
        public SupportCardRarity        Rarity;                         // 64 enum
        public string                   AssetId;                        // 72
        public string                   SupportCardLevelId;             // 80
        public string                   SupportCardLevelLimitId;        // 88
        public string[]                 ProduceStoryIds;                // 96
        public float                    DisplayPositionX;               // 104
        public float                    DisplayPositionY;               // 108
        public float                    DisplayScale;                   // 112
        public Reward                   ExchangeReward;                 // 120 class
        public bool                     IsLimited;                      // 128
        public int                      ProduceCardUpgradePermil;       // 132
        public string                   UpgradeProduceCardSearchId;     // 136
        public ProduceParameterType     ProduceCardUpgradeLessonParameterType; // 144 enum
        public int                      GashaSupportAnimationNumber;    // 148
        public ProduceDescriptionSegment[] UpgradeProduceCardProduceDescriptions; // 152
        public long                     ViewStartTime;                  // 160
        public long                     Order;                          // 168
    }
}
