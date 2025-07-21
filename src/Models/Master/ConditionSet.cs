using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ConditionSet
    {
        public string                   Id;                             // 24
        public int                      Number;                         // 32
        public ConditionOperatorType    ConditionOperatorType;          // 36 enum
        public ConditionType            ConditionType;                  // 40 enum
        public string                   ResourceId1;                    // 48
        public string                   ResourceId2;                    // 56
        public ConditionMinMaxType      MinMaxType;                     // 64 enum
        public long                     Min;                            // 72
        public long                     Max;                            // 80
        public long                     BeforeTime;                     // 88
        public long                     AfterTime;                      // 96
        public string                   Description;                    // 104
    }
}
