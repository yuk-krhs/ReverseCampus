using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class GuildDonationItem
    {
        public string                   ItemId;                         // 24
        public int                      Order;                          // 32
        public string                   NameCache;                      // 40
        public string                   DescriptionCache;               // 48
        public RarityType?              RarityTypeCache;                // 56 enum
    }
}
