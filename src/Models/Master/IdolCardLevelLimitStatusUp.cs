using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class IdolCardLevelLimitStatusUp
    {
        public string                   Id;                             // 24
        public IdolCardLevelLimitRank   Rank;                           // 32 enum
        public IdolCardLevelLimitEffectType[] EffectTypes;                    // 40
        public int                      EffectValue;                    // 48
        public int                      ProduceVocal;                   // 52
        public int                      ProduceDance;                   // 56
        public int                      ProduceVisual;                  // 60
        public bool                     IsIllustrationChange;           // 64
    }
}
