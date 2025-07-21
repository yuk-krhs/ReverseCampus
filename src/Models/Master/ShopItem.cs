using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ShopItem
    {
        public string                   Id;                             // 32
        public string                   ShopId;                         // 40
        public string                   Name;                           // 48
        public ShopItemLabelType[]      LabelTypes;                     // 56
        public string                   AssetId;                        // 64
        public string                   ShopProductId;                  // 72
        public int                      TotalJewelQuantity;             // 80
        public int                      PaidOnlyJewelQuantity;          // 84
        public Reward[]                 Rewards;                        // 88
        public string                   ViewConditionSetId;             // 96
        public string                   UnlockConditionSetId;           // 104
        public ResetTimingType          ResetTimingType;                // 112 enum
        public int                      ResetHour;                      // 116
        public int                      ResetMinute;                    // 120
        public Weekday                  ResetWeekday;                   // 124 enum
        public int                      ResetDay;                       // 128
        public int                      PurchaseLimit;                  // 132
        public ResourceType             ConsumptionResourceType;        // 136 enum
        public string                   ConsumptionResourceId;          // 144
        public int                      ConsumptionResourceQuantity;    // 152
        public long                     StartTime;                      // 160
        public long                     EndTime;                        // 168
        public int                      Order;                          // 176
    }
}
