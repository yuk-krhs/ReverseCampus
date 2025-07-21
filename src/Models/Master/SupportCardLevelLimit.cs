using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class SupportCardLevelLimit
    {
        public string                   Id;                             // 24
        public SupportCardLevelLimitRank Rank;                           // 32 enum
        public int                      LevelLimit;                     // 36
    }
}
