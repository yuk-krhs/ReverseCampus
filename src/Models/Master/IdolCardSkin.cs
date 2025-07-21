using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class IdolCardSkin
    {
        public string                   Id;                             // 32
        public string                   IdolCardId;                     // 40
        public string                   Name;                           // 48
        public string                   AssetId;                        // 56
        public string                   CostumeHeadId;                  // 64
        public string                   CostumeId;                      // 72
        public string                   MusicId;                        // 80
        public int                      IdolCardSsrAnimationStartMilliseconds; // 88
        public string                   HomeVoiceGroupId;               // 96
        public string                   DetailVoiceGroupId;             // 104
        public string                   BeforeLevelLimitRankVoiceAssetId; // 112
        public string                   AfterLevelLimitRankVoiceAssetId; // 120
        public string                   ProduceSelectVoiceAssetId;      // 128
        public string                   ProduceSelectFacialAssetId;     // 136
        public string                   ProduceSelectBodyAssetId;       // 144
        public string                   ProduceScheduleVoiceGroupId;    // 152
        public string                   LevelLimitRank7VoiceAssetId;    // 160
        public bool                     HasProduceIdolAnimation;        // 168
        public bool                     HasGashaAnimation;              // 169
        public bool                     IsProduceIdolAnimationStillCard; // 170
        public float                    BeforeListPositionX;            // 172
        public float                    BeforeListPositionY;            // 176
        public float                    BeforeListScale;                // 180
        public float                    AfterListPositionX;             // 184
        public float                    AfterListPositionY;             // 188
        public float                    AfterListScale;                 // 192
        public float                    BeforeDetailPositionX;          // 196
        public float                    BeforeDetailPositionY;          // 200
        public float                    BeforeDetailScale;              // 204
        public float                    AfterDetailPositionX;           // 208
        public float                    AfterDetailPositionY;           // 212
        public float                    AfterDetailScale;               // 216
        public int                      BeforeLevelLimitRankPositionPattern; // 220
        public int                      AfterLevelLimitRankPositionPattern; // 224
        public long                     ViewStartTime;                  // 232
        public long                     Order;                          // 240
    }
}
