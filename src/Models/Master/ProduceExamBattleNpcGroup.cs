using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceExamBattleNpcGroup
    {
        public string                   Id;                             // 24
        public int                      Number;                         // 32
        public string                   CharacterId;                    // 40
        public string                   ProduceExamBattleNpcMobId;      // 48
        public int                      ScoreMin;                       // 56
        public int                      ScoreMax;                       // 60
        public int                      VocalPermil;                    // 64
        public int                      DancePermil;                    // 68
        public int                      VisualPermil;                   // 72
        public int                      OpScorePermil;                  // 76
        public int                      MidScorePermil;                 // 80
        public int                      EdScorePermil;                  // 84
    }
}
