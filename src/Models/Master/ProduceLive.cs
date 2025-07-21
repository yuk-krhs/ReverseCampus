using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceLive
    {
        public string                   MusicId;                        // 32
        public ProduceLiveType          Type;                           // 40 enum
        public string                   ForceUnlockConditionSetId;      // 48
        public string                   UnlockConditionSetId;           // 56
        public string                   ThumbnailAssetId;               // 64
        public string                   EnvironmentAssetId;             // 72
        public string                   TimelineAssetId;                // 80
        public string                   BeforeAdvAssetId;               // 88
        public string                   AfterAdvAssetId;                // 96
        public string                   LiveMusicAssetId;               // 104
        public string[]                 MotionAssetIds;                 // 112
        public string[]                 UnitLiveThumbnailAssetCharacterIds; // 120
        public string[]                 UnitLiveThumbnailAssetIds;      // 128
        public string                   LiveOverrideAssetId;            // 136
        public string[]                 AdditionalActorAssetIds;        // 144
    }
}
