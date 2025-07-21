using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class PvpRateCommonProduceCard
    {
        public string                   Id;                             // 24
        public ProducePlanType          PlanType;                       // 32 enum
        public ProduceCard[]            ProduceCards;                   // 40
    }
}
