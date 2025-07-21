using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceEventCharacterGrowth
    {
        public string                   CharacterId;                    // 24
        public int                      Number;                         // 32
        public string                   Title;                          // 40
        public string                   Description;                    // 48
        public int                      Vocal;                          // 56
        public int                      Dance;                          // 60
        public int                      Visual;                         // 64
        public string                   ProduceStepEventDetailId;       // 72
    }
}
