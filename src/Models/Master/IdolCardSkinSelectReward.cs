using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class IdolCardSkinSelectReward
    {
        public string                   Id;                             // 32
        public string                   IdolCardSkinId;                 // 40
        public string                   MovieAssetId;                   // 48
        public IdolCardDifficultyType   DifficultyType;                 // 56 enum
        public int                      Order;                          // 60
    }
}
