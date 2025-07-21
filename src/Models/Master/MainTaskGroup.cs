using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MainTaskGroup
    {
        public string                   Id;                             // 24
        public string                   Title;                          // 32
        public MainTaskType             MainTaskType;                   // 40 enum
        public string                   ViewConditionSetId;             // 48
        public string                   BackgroundAssetId;              // 56
        public int                      Order;                          // 64
    }
}
