using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Item
    {
        public string                   Id;                             // 32
        public string                   Name;                           // 40
        public string                   Description;                    // 48
        public string                   AcquisitionRouteDescription;    // 56
        public string                   AssetId;                        // 64
        public ItemType                 Type;                           // 72 enum
        public ItemRarity               Rarity;                         // 76 enum
        public long                     CommonLimitTime;                // 80
        public int                      PersonalLimitDay;               // 88
        public int                      SellPrice;                      // 92
        public int                      EffectValue;                    // 96
        public bool                     ViewWithoutPossession;          // 100
        public ExchangeType             ExchangeType;                   // 104 enum
        public string                   ExchangeId;                     // 112
        public string                   GashaId;                        // 120
        public string                   CoinGashaId;                    // 128
        public string                   ShopCoinGashaId;                // 136
        public string                   StoryEventId;                   // 144
        public string                   ProduceHighScoreEventId;        // 152
        public IdolCardRarity           IdolCardRarity;                 // 160 enum
        public SupportCardRarity        SupportCardRarity;              // 164 enum
        public string                   CharacterId;                    // 168
        public Gasha[]                  Gashas;                         // 176
        public string                   ViewConditionSetId;             // 184
        public string                   UnlockConditionSetId;           // 192
        public long                     StartTime;                      // 200
        public long                     EndTime;                        // 208
        public int                      Order;                          // 216
    }
}
