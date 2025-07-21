using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class TutorialProduce
    {
        public TutorialType             TutorialType;                   // 24 enum
        public string                   IdolCardId;                     // 32
        public string[]                 ProduceCardIds;                 // 40
        public string                   ExamSettingId;                  // 48
        public string                   ProduceSettingId;               // 56
        public int                      IdolCardParameterGrowthLimit;   // 64
        public string                   ProduceNavigationNormalId;      // 72
        public string                   ProduceNavigationAuditionId;    // 80
        public string                   MusicId;                        // 88
        public string                   EnvironmentAssetId;             // 96
        public string                   TimelineAssetId;                // 104
        public string                   MemoryGiftId;                   // 112
    }
}
