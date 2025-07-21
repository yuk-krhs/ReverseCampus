using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Character
    {
        public string                   Id;                             // 32
        public string                   LastName;                       // 40
        public string                   FirstName;                      // 48
        public string                   AlphabetLastName;               // 56
        public string                   AlphabetFirstName;              // 64
        public bool                     IsPlayable;                     // 72
        public CharacterPersonalityType PersonalityType;                // 76 enum
        public string                   CharacterTrueEndBonusId;        // 80
        public string[]                 AchievementIds;                 // 88
        public string                   MasterAchievementId;            // 96
        public string[]                 IdolCardIds;                    // 104
        public string[]                 SupportCardIds;                 // 112
        public string                   ChangeCostumeConditionSetId;    // 120
        public string                   ViewConditionSetId;             // 128
        public string                   NormalCostumeHeadId;            // 136
        public string                   TrainingCostumeHeadId;          // 144
        public string                   LiveCostumeHeadId;              // 152
        public string                   NormalCostumeId;                // 160
        public string                   TrainingCostumeId;              // 168
        public string                   LiveCostumeId;                  // 176
        public string                   DearnessMissionGroupId;         // 184
        public string                   DearnessStoryUnlockItemId;      // 192
        public string[]                 OtherStoryIds;                  // 200
        public string                   PotentialRank1VoiceAssetId;     // 208
        public string                   PotentialRank3VoiceAssetId;     // 216
        public string                   PotentialRank4VoiceAssetId;     // 224
        public float                    StandingListPositionX;          // 232
        public float                    StandingListPositionY;          // 236
        public float                    RosterDetailPositionX;          // 240
        public float                    RosterDetailPositionY;          // 244
        public float                    StoryPositionX;                 // 248
        public float                    StoryPositionY;                 // 252
        public float                    ProduceHighScorePositionX;      // 256
        public float                    ProduceHighScorePositionY;      // 260
        public float                    ProduceHighScoreRushPositionX;  // 264
        public float                    ProduceHighScoreRushPositionY;  // 268
        public int                      Order;                          // 272
    }
}
