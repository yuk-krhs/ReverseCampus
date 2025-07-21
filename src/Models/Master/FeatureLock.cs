using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class FeatureLock
    {
        public TutorialType             TutorialType;                   // 24 enum
        public string                   Name;                           // 32
        public string                   Description;                    // 40
        public string                   RouteDescription;               // 48
        public string                   UnlockConditionSetId;           // 56
        public bool                     IsForce;                        // 64
        public string                   ViewConditionSetId;             // 72
    }
}
