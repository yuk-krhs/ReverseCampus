using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MissionPanelSheet
    {
        public string                   MissionPanelSheetGroupId;       // 24
        public int                      Number;                         // 32
        public string                   Name;                           // 40
        public string                   MissionGroupId;                 // 48
        public string                   IconAssetId;                    // 56
        public string                   BackgroundAssetId;              // 64
        public string                   RewardAssetId;                  // 72
        public string                   BackgroundGradientColor1;       // 80
        public string                   BackgroundGradientColor2;       // 88
        public string[]                 PanelGradientColors1;           // 96
        public string[]                 PanelGradientColors2;           // 104
    }
}
