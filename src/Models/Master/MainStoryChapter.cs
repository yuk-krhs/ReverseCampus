using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MainStoryChapter
    {
        public string                   MainStoryPartId;                // 32
        public string                   Id;                             // 40
        public string                   Title;                          // 48
        public string                   Description;                    // 56
        public string                   StoryAssetId;                   // 64
        public string                   MainStoryGroupId;               // 72
        public int                      Order;                          // 80
    }
}
