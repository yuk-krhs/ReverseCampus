using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class TitleAsset
    {
        public string                   Id;                             // 32
        public int                      Order;                          // 40
        public int                      Number;                         // 44
        public bool                     NoLoop;                         // 48
        public string                   MovieAssetId;                   // 56
        public string                   BgmAssetId;                     // 64
        public string                   ConditionSetId;                 // 72
        public long                     StartTime;                      // 80
        public long                     EndTime;                        // 88
        public int                      Priority;                       // 96
    }
}
