using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceExamBattleConfig
    {
        public string                   Id;                             // 24
        public int                      Turn;                           // 32
        public int                      Vocal;                          // 36
        public int                      Dance;                          // 40
        public int                      Visual;                         // 44
        public string                   ProduceExamBattleScoreConfigId; // 48
        public int                      VocalExcellent;                 // 56
        public int                      DanceExcellent;                 // 60
        public int                      VisualExcellent;                // 64
        public int                      VocalBad;                       // 68
        public int                      DanceBad;                       // 72
        public int                      VisualBad;                      // 76
    }
}
