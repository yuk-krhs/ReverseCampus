using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ExchangeItemCategory
    {
        public string                   ExchangeId;                     // 24
        public int                      Number;                         // 32
        public string                   Name;                           // 40
        public ExchangeItemCategoryType CategoryType;                   // 48 enum
        public ResourceType             ResourceType;                   // 52 enum
        public ItemType                 ItemType;                       // 56 enum
    }
}
