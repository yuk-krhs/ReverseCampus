using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class SupportCardProduceSkillFilter
    {
        public string                   Id;                             // 24
        public string                   Title;                          // 32
        public int                      Order;                          // 40
        public ProduceEffectType[]      ProduceEffectTypes;             // 48
        public string[]                 ProduceTriggerIds;              // 56
    }
}
