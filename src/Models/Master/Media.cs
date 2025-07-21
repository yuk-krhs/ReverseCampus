using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Media
    {
        public string                   Id;                             // 32
        public string                   Name;                           // 40
        public MediaType                MediaType;                      // 48 enum
        public string                   AssetId;                        // 56
        public string                   ThumbnailAssetId;               // 64
        public string                   ViewConditionSetId;             // 72
        public string[]                 CharacterIds;                   // 80
        public string                   ExternalUrl;                    // 88
        public int                      FourPanelComicEpisode;          // 96
        public string                   Caption;                        // 104
        public FourPanelComicSeries     FourPanelComicSeries;           // 112 enum
        public long                     StartTime;                      // 120
        public long                     EndTime;                        // 128
        public int                      Order;                          // 136
    }
}
