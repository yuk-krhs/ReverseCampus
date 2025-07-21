using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class GashaAnimationStep
    {
        public GashaAnimationRarity     Rarity;                         // 24 enum
        public GashaAnimationStepType   CurrentStepType;                // 28 enum
        public int                      CurrentNumber;                  // 32
        public GashaAnimationStepType   NextStepType;                   // 36 enum
        public int                      NextNumber;                     // 40
        public int                      Ratio;                          // 44
    }
}
