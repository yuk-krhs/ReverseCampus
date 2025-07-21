using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceGroup
    {
        public string                   Id;                             // 32
        public string                   Name;                           // 40
        public ProduceType              Type;                           // 48 enum
        public string[]                 ProduceIds;                     // 56
        public string                   AssetId;                        // 64
        public string                   ViewConditionSetId;             // 72
        public string                   UnlockConditionSetId;           // 80
        public string                   FailedProduceMemoryAssetId;     // 88
        public string                   Description;                    // 96
        public bool                     IsForceLiveCommon;              // 104
        public ProduceLiveType          DisableForceLiveCommonEndingLiveType; // 108 enum
        public ResultGrade              LimitGrade;                     // 112 enum
        public int                      Order;                          // 116
    }
}
