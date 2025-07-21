using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class IdolCard
    {
        public string                   Id;                             // 24
        public string                   CharacterId;                    // 32
        public string                   OriginalIdolCardSkinId;         // 40
        public string                   AssetId;                        // 48
        public string                   Name;                           // 56
        public IdolCardRarity           Rarity;                         // 64 enum
        public bool                     IsLimited;                      // 68
        public string                   AnotherCostumeHeadId;           // 72
        public string                   AnotherCostumeId;               // 80
        public string                   IdolCardPotentialId;            // 88
        public string                   IdolCardPotentialProduceSkillId; // 96
        public string                   IdolCardLevelLimitId;           // 104
        public string                   IdolCardLevelLimitProduceSkillId; // 112
        public IdolCardLevelLimitRank   MaxIdolCardLevelLimitRank;      // 120 enum
        public ProducePlanType          PlanType;                       // 124 enum
        public string                   IdolCardLevelLimitStatusUpId;   // 128
        public int                      ProduceVocal;                   // 136
        public int                      ProduceDance;                   // 140
        public int                      ProduceVisual;                  // 144
        public int                      ProduceVocalGrowthRatePermil;   // 148
        public int                      ProduceDanceGrowthRatePermil;   // 152
        public int                      ProduceVisualGrowthRatePermil;  // 156
        public int                      ProduceStamina;                 // 160
        public string                   ProduceStepAuditionDifficultyId; // 168
        public string                   ExamInitialDeckId;              // 176
        public string                   ProduceCardId;                  // 184
        public string                   BeforeProduceItemId;            // 192
        public string                   AfterProduceItemId;             // 200
        public ProduceExamEffectType    ExamEffectType;                 // 208 enum
        public string                   ProduceChallengeSlotId;         // 216
        public ProduceExamEffectType    ShowExamEffectType;             // 224 enum
        public string                   PotentialRankVoiceAssetId;      // 232
        public string                   ProduceSelectVoiceAssetId;      // 240
        public string                   ProduceScheduleFrontVoiceGroupId; // 248
        public string                   ProduceScheduleBackVoiceGroupId; // 256
        public string                   UseProduceCardVoiceAssetId;     // 264
        public long                     ViewStartTime;                  // 272
        public long                     Order;                          // 280
        public string[]                 ProduceStoryIds;                // 288
        public string[]                 AchievementIds;                 // 296
    }
}
