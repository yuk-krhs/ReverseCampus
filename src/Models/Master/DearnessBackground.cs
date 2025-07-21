using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class DearnessBackground
    {
        public string                   CharacterId;                    // 24
        public int                      DearnessLevel;                  // 32
        public int                      Number;                         // 36
        public string                   BackgroundAssetId;              // 40
        public string                   SceneLayoutCollectionId;        // 48
        public string                   SceneLayoutId;                  // 56
        public string                   ConditionSetId;                 // 64
        public bool                     IsDearnessBoost;                // 72
    }
}
