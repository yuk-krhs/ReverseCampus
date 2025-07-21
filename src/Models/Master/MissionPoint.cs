using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MissionPoint
    {
        public string                   Id;                             // 24
        public string                   Name;                           // 32
        public ResetTimingType          ResetTimingType;                // 40 enum
        public string                   AssetId;                        // 48
    }
}
