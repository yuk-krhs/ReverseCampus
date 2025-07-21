using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceDescriptionLabel
    {
        public string                   Id;                             // 24
        public string                   Name;                           // 32
        public string                   ProduceDescriptionSwapId;       // 40
        public ProduceDescriptionSegment[] ProduceDescriptions;            // 48
    }
}
