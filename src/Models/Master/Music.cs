using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Music
    {
        public string                   Id;                             // 32
        public string                   Title;                          // 40
        public string                   DisplayTitle;                   // 48
        public string                   Lyrics;                         // 56
        public string                   Composer;                       // 64
        public string                   Arranger;                       // 72
        public MusicType                Type;                           // 80 enum
        public string                   JacketAssetId;                  // 88
        public string                   GameVersionAssetId;             // 96
        public string                   IdolCardSkinUnitId;             // 104
        public int                      ShortVersionStartMilliseconds;  // 112
        public int                      ShortVersionEndMilliseconds;    // 116
        public string                   ViewConditionSetId;             // 120
        public string                   UnlockConditionSetId;           // 128
        public string                   ProduceLiveUnlockItemConditionSetId; // 136
        public string                   ExternalUrl;                    // 144
        public long                     ViewStartTime;                  // 152
        public int                      Order;                          // 160
    }
}
