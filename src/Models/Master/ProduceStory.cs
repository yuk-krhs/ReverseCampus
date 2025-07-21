using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceStory
    {
        public string                   Id;                             // 32
        public ProduceStoryType         Type;                           // 40 enum
        public string                   Title;                          // 48
        public string                   AdvAssetId;                     // 56
        public string[]                 ProduceEventHintProduceConditionDescriptions; // 64
        public string                   ViewConditionSetId;             // 72
        public string                   UnlockConditionSetId;           // 80
        public bool                     IsBusinessExcellent;            // 88
        public int                      Order;                          // 92
    }
}
