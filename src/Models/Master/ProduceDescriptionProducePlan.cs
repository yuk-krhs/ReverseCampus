using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceDescriptionProducePlan
    {
        public ProducePlanType          Type;                           // 24 enum
        public string                   Name;                           // 32
        public string                   ProduceDescriptionLabelId;      // 40
        public string                   PlanDetailProduceDescriptionLabelId; // 48
    }
}
