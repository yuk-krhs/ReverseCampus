using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class IdolCardPiece
    {
        public string                   IdolCardId;                     // 24
        public string                   ItemId;                         // 32
        public int                      ReleaseConsumptionQuantity;     // 40
        public Reward                   ExchangeReward;                 // 48 class
    }
}
