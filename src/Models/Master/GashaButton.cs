using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class GashaButton
    {
        public string                   Id;                             // 24
        public string                   Name;                           // 32
        public string                   Description;                    // 40
        public GashaButtonType          Type;                           // 48 enum
        public int                      RewardCount;                    // 52
        public int                      FixRewardCount;                 // 56
        public ResourceType             ResourceType;                   // 60 enum
        public string                   ResourceId;                     // 64
        public GashaLimitType           LimitType;                      // 72 enum
        public int                      LimitCount;                     // 76
        public int                      ResourceQuantity;               // 80
        public int                      MaxDrawCount;                   // 84
        public GashaLimitType           DiscountLimitType;              // 88 enum
        public int                      DiscountLimitCount;             // 92
        public int                      DiscountResourceQuantity;       // 96
        public string                   ViewConditionSetId;             // 104
        public string                   UnlockConditionSetId;           // 112
        public int                      Order;                          // 120
        public GashaButtonAppealType    AppealType;                     // 124 enum
        public string                   AppealText;                     // 128
        public GashaButtonAppealType    HighAppealType;                 // 136 enum
        public string                   HighAppealText;                 // 144
    }
}
