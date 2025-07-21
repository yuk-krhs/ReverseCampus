using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Costume
    {
        public string                   Id;                             // 32
        public string                   CharacterId;                    // 40
        public string                   Name;                           // 48
        public string                   MotifId;                        // 56
        public string                   Description;                    // 64
        public string                   CostumeColorGroupId;            // 72
        public string                   CostumeHeadId;                  // 80
        public string                   DefaultCostumeHeadId;           // 88
        public string                   VoiceGroupId;                   // 96
        public ResourceOriginType       ResourceOriginType;             // 104 enum
        public string                   TargetId;                       // 112
        public bool                     IsTraining;                     // 120
        public bool                     IsBarefoot;                     // 121
        public bool                     IsCommonThumbnail;              // 122
        public CostumeFeatureType[]     InvalidCostumeFeatureTypes;     // 128
        public int                      CostumeWaitMotionNumber;        // 136
        public string                   ViewConditionSetId;             // 144
        public long                     ViewStartTime;                  // 152
        public int                      Order;                          // 160
    }
}
