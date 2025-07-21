using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ExamInitialDeck
    {
        public string                   Id;                             // 24
        public string[]                 ProduceCardIds;                 // 32
        public int[]                    ProduceCardUpgradeCounts;       // 40
    }
}
