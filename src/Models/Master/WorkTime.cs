using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class WorkTime
    {
        public WorkType                 Type;                           // 24 enum
        public int                      DurationMinutes;                // 28
        public string                   ViewConditionSetId;             // 32
        public string                   UnlockConditionSetId;           // 40
    }
}
