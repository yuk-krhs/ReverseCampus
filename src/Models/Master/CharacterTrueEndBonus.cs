using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class CharacterTrueEndBonus
    {
        public string                   Id;                             // 24
        public ProduceType              ProduceType;                    // 32 enum
        public int                      ProduceVocal;                   // 36
        public int                      ProduceDance;                   // 40
        public int                      ProduceVisual;                  // 44
        public int                      ProduceVocalGrowthRatePermil;   // 48
        public int                      ProduceDanceGrowthRatePermil;   // 52
        public int                      ProduceVisualGrowthRatePermil;  // 56
        public int                      ProduceStamina;                 // 60
    }
}
