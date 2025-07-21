using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ShopProduct
    {
        public string                   Id;                             // 24
        public string                   AppStoreProductId;              // 32
        public string                   GooglePlayStoreProductId;       // 40
        public string                   DmmGamesProductId;              // 48
        public int                      Jewel;                          // 56
        public int                      PriceJpy;                       // 60
        public string                   RecoverName;                    // 64
    }
}
