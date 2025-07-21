using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Stage
    {
        public PvpRateStageType         StageType;                      // 24 enum
        public ProducePlanType          PlanType;                       // 28 enum
        public int                      Turn;                           // 32
        public string                   ProduceItemId;                  // 40
        public string[]                 ProduceItemIds;                 // 48
        public string                   ProduceExamGimmickEffectGroupId; // 56
        public string                   BgmAssetId;                     // 64
        public string                   StartTimelineAssetId;           // 72
        public string                   ExamTimelineAssetId;            // 80
    }
}
