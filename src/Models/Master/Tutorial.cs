using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Tutorial
    {
        public TutorialType             TutorialType;                   // 32 enum
        public string                   IdolCardId;                     // 40
        public int                      Step;                           // 48
        public int                      SubStep;                        // 52
        public TutorialNavigationType   NavigationType;                 // 56 enum
        public TutorialNavigationPositionType NavigationPositionType;         // 60 enum
        public string                   Title;                          // 64
        public string[]                 Texts;                          // 72
        public string[]                 AssetIds;                       // 80
        public string                   AdvAssetId;                     // 88
        public TutorialProduceCommandType TutorialProduceCommandType;     // 96 enum
    }
}
