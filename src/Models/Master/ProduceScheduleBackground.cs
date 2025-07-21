using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceScheduleBackground
    {
        public ProduceScheduleLocationType LocationType;                   // 32 enum
        public string                   BackgroundAssetId;              // 40
        public string                   SceneLayoutId;                  // 48
        public string                   MonitorMovieId;                 // 56
        public string[]                 ProduceGroupIds;                // 64
    }
}
