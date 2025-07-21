using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class WorkLevel
    {
        public WorkType                 Type;                           // 24 enum
        public int                      Level;                          // 28
        public string                   UnlockConditionSetId;           // 32
    }
}
