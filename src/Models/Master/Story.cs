using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Story
    {
        public string                   Id;                             // 32
        public StoryType                Type;                           // 40 enum
        public string                   CharacterId;                    // 48
        public string                   Title;                          // 56
        public string                   ThumbnailAssetId;               // 64
        public string                   AdvAssetId;                     // 72
        public string                   ViewConditionSetId;             // 80
        public string                   UnlockConditionSetId;           // 88
        public Reward                   Reward;                         // 96 class
        public string                   PreviousStoryId;                // 104
        public int                      Order;                          // 112
    }
}
