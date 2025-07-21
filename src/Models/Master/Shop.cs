using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Shop
    {
        public string                   Id;                             // 24
        public ShopType                 Type;                           // 32 enum
        public string                   Name;                           // 40
        public ResetTimingType          ResetTimingType;                // 48 enum
        public int                      ResetHour;                      // 52
        public int                      ResetMinute;                    // 56
        public Weekday                  ResetWeekday;                   // 60 enum
        public int                      ResetDay;                       // 64
        public long                     StartTime;                      // 72
        public long                     EndTime;                        // 80
        public int                      Order;                          // 88
    }
}
