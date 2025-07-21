using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class IdolCardLevelLimitProduceSkill
    {
        public string                   Id;                             // 24
        public string                   ProduceSkillId;                 // 32
        public int                      ProduceSkillLevel;              // 40
        public IdolCardLevelLimitRank   Rank;                           // 44 enum
        public int                      Order;                          // 48
    }
}
