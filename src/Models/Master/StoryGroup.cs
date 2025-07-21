using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class StoryGroup
    {
        public string                   Id;                             // 24
        public StoryType                StoryType;                      // 32 enum
        public StoryEventType           StoryEventType;                 // 36 enum
        public bool                     IsCampaign;                     // 40
        public EventStoryFilterType     EventStoryFilterType;           // 44 enum
        public string                   Title;                          // 48
        public string                   HeaderAssetId;                  // 56
        public string                   StoryThumbnailAssetId;          // 64
        public string                   ViewConditionSetId;             // 72
        public string                   CharacterId;                    // 80
        public int                      DearnessLevelMin;               // 88
        public int                      DearnessLevelMax;               // 92
        public string[]                 StoryIds;                       // 96
        public string                   StoryEventId;                   // 104
        public int                      Order;                          // 112
    }
}
