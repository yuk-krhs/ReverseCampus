using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class CharacterProduceStory
    {
        public string                   CharacterId;                    // 24
        public string                   ProduceGroupId;                 // 32
        public string[]                 EventCharacterProduceStoryIds;  // 40
        public string[]                 EventCharacterGrowthProduceStoryIds; // 48
        public string[]                 EventCampaignProduceStoryIds;   // 56
        public string[]                 EventActivityProduceStoryIds;   // 64
        public string[]                 EventSchoolProduceStoryIds;     // 72
        public string[]                 EventBusinessProduceStoryIds;   // 80
    }
}
