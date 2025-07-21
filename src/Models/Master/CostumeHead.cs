using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class CostumeHead
    {
        public string                   Id;                             // 32
        public string                   CharacterId;                    // 40
        public string                   Name;                           // 48
        public string                   HairAssetId;                    // 56
        public string                   FaceAssetId;                    // 64
        public string                   Description;                    // 72
        public ResourceOriginType       ResourceOriginType;             // 80 enum
        public string                   TargetId;                       // 88
        public bool                     IsTraining;                     // 96
        public bool                     NoGashaAppeal;                  // 97
        public string                   ViewConditionSetId;             // 104
        public long                     ViewStartTime;                  // 112
        public int                      Order;                          // 120
    }
}
