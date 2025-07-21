using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Work
    {
        public WorkType                 Type;                           // 24 enum
        public string                   Name;                           // 32
        public string                   UnlockConditionSetId;           // 40
        public ResourceType             RewardResourceType;             // 48 enum
        public string                   RewardResourceId;               // 56
    }
}
