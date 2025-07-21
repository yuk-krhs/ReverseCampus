using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceGroupLiveCommon
    {
        public string                   CharacterId;                    // 32
        public string                   ProduceGroupId;                 // 40
        public ProduceLiveType          Type;                           // 48 enum
        public string                   MusicId;                        // 56
        public bool                     NeedForceLiveCommonIdolCard;    // 64
        public string                   UnlockConditionSetId;           // 72
        public string                   ThumbnailAssetId;               // 80
        public string                   EnvironmentAssetId;             // 88
        public string                   TimelineAssetId;                // 96
        public string[]                 MotionAssetIds;                 // 104
        public string                   LiveMusicAssetId;               // 112
        public string                   BeforeAdvAssetId;               // 120
        public string                   AfterAdvAssetId;                // 128
        public string                   LiveOverrideAssetId;            // 136
        public string[]                 AdditionalActorAssetIds;        // 144
    }
}
