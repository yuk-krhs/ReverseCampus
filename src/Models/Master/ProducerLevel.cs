using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProducerLevel
    {
        public int                      Level;                          // 24
        public int                      TotalExp;                       // 28
        public UnlockTarget[]           UnlockTargets;                  // 32
        public Reward                   Reward;                         // 40 class
        public Reward[]                 BonusRewards;                   // 48
    }
}
