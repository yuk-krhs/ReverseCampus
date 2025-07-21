using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class IdolCardLevelLimit
    {
        public string                   Id;                             // 24
        public IdolCardLevelLimitRank   Rank;                           // 32 enum
        public string                   ConsumptionSetId;               // 40
    }
}
