using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceGuideProduceCardCategory
    {
        public string                   Id;                             // 24
        public string                   Label;                          // 32
        public int                      ProduceCardCount;               // 40
        public string[]                 EffectGroupIds;                 // 48
        public string[]                 ProduceCardIds;                 // 56
    }
}
