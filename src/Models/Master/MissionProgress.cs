using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MissionProgress
    {
        public string                   MissionId;                      // 24
        public int                      Threshold;                      // 32
        public int                      MissionPoint;                   // 36
        public Reward[]                 Rewards;                        // 40
    }
}
