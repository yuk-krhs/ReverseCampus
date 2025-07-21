using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MemoryGift
    {
        public string                   Id;                             // 24
        public string                   Name;                           // 32
        public string                   Description;                    // 40
        public string                   AssetId;                        // 48
        public ResultGrade              Grade;                          // 56 enum
        public string                   IdolCardId;                     // 64
        public ProducePlanType          PlanType;                       // 72 enum
        public ProduceCard              ProduceCard;                    // 80 class
        public ProduceMemoryProduceCardPhaseType ProduceCardPhaseType;           // 88 enum
        public MemoryAbility[]          MemoryAbilities;                // 96
        public int                      Vocal;                          // 104
        public int                      Dance;                          // 108
        public int                      Visual;                         // 112
        public int                      Stamina;                        // 116
        public ProduceCard[]            ExamBattleProduceCards;         // 120
        public string[]                 ExamBattleProduceItemIds;       // 128
        public bool                     IsProtected;                    // 136 Campus.Common.Data.IMemoryInfo.IsProtected
        public bool                     IsUsePvpRate;                   // 137 Campus.Common.Data.IMemoryInfo.IsUsePvpRate
        public bool                     IsUseTower;                     // 138 Campus.Common.Data.IMemoryInfo.IsUseTower
        public bool                     IsUseProduce;                   // 139 Campus.Common.Data.IMemoryInfo.IsUseProduce
        public bool                     IsSetProfile;                   // 140 Campus.Common.Data.IMemoryInfo.IsSetProfile
        public bool                     IsSetMeishi;                    // 141 Campus.Common.Data.IMemoryInfo.IsSetMeishi
        public string                   ImagePath;                      // 144 Campus.Common.Data.IMemoryInfo.ImagePath
    }
}
