using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Rule
    {
        public RuleType                 Type;                           // 24 enum
        public PlatformType             PlatformType;                   // 28 enum
        public int                      Number;                         // 32
        public string                   Html;                           // 40
    }
}
