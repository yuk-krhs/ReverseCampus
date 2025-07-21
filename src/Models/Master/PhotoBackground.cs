using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class PhotoBackground
    {
        public string                   Id;                             // 32
        public string                   Name;                           // 40
        public string                   BgmAssetId;                     // 48
        public PhotoBackgroundCategory  Category;                       // 56 enum
        public int                      MaxCharacterCount;              // 60
        public int[]                    EnableLookTargetPositionNumbers; // 64
        public string                   BackgroundAssetId;              // 72
        public PhotoBackgroundTimeType[] TimeTypes;                      // 80
        public string                   PhotoBackgroundPrefab;          // 88
        public string                   SceneLayoutId;                  // 96
        public string                   CostumePhotoGroup;              // 104
        public string                   NgCostumePhotoGroupId;          // 112
        public string                   ViewConditionSetId;             // 120
        public string                   UnlockConditionSetId;           // 128
        public int                      Order;                          // 136
    }
}
