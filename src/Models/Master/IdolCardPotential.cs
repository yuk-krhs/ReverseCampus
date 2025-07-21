using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class IdolCardPotential
    {
        public string                   Id;                             // 24
        public IdolCardPotentialRank    Rank;                           // 32 enum
        public IdolCardPotentialEffectType[] EffectTypes;                    // 40
        public int                      EffectValue;                    // 48
        public int                      ProduceVocalGrowthRatePermil;   // 52
        public int                      ProduceDanceGrowthRatePermil;   // 56
        public int                      ProduceVisualGrowthRatePermil;  // 60
        public bool                     AnotherCostumeProvide;          // 64
        public int                      ConsumptionPiece;               // 68
    }
}
