using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MissionDailyReleaseGroup
    {
        public string                   Id;                             // 24
        public string                   Name;                           // 32
        public string                   LogoAssetId;                    // 40
        public string                   BannerAssetId;                  // 48
        public string                   GradientColor1;                 // 56
        public string                   GradientColor2;                 // 64
        public string                   GradientColor3;                 // 72
        public string                   MissionPointId;                 // 80
        public string                   ConditionSetId;                 // 88
        public bool                     FromStartTimeUnlock;            // 96
        public long                     StartTime;                      // 104
        public long                     EndTime;                        // 112
    }
}
