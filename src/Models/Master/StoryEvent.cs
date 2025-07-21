using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class StoryEvent
    {
        public string                   Id;                             // 24
        public string                   Title;                          // 32
        public StoryEventType           StoryEventType;                 // 40 enum
        public string                   TitleAssetId;                   // 48
        public string                   BannerAssetId;                  // 56
        public string                   StoryGroupId;                   // 64
        public string                   IdolCardSkinBeforeAssetId;      // 72
        public string                   IdolCardSkinAfterAssetId;       // 80
        public int                      Order;                          // 88
    }
}
