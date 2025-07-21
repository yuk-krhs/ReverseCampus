using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Tips
    {
        public string                   Id;                             // 24
        public TipsType                 Type;                           // 32 enum
        public string                   Title;                          // 40
        public string                   Description;                    // 48
        public string                   CharacterId;                    // 56
        public string                   MediaId;                        // 64
        public ViewAreaType             ViewAreaType;                   // 72 enum
        public string                   ViewConditionSetId;             // 80
        public long                     StartTime;                      // 88
        public long                     EndTime;                        // 96
    }
}
