using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceHighScore
    {
        public string                   Id;                             // 24
        public string                   Name;                           // 32
        public ProduceHighScoreEventType ProduceHighScoreEventType;      // 40 enum
        public int                      Order;                          // 44
    }
}
