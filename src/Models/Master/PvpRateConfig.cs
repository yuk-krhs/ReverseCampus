using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class PvpRateConfig
    {
        public string                   Id;                             // 32
        public string                   Description;                    // 40
        public int                      Vocal;                          // 48
        public int                      Dance;                          // 52
        public int                      Visual;                         // 56
        public string                   ExamSettingId;                  // 64
        public string                   ProduceExamBattleScoreConfigId; // 72
        public int                      ExamBattleFirstRankBonusPermil; // 80
        public string                   PvpRateCommonProduceCardId;     // 88
        public string                   WinTimelineAssetId;             // 96
        public string                   LoseTimelineAssetId;            // 104
        public int                      StartTimelineInitialTimePermil; // 112
        public string                   TopAssetId;                     // 120
        public Stage[]                  Stages;                         // 128
    }
}
