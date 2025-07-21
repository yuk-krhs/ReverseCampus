using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceStepEventDetail
    {
        public string                   Id;                             // 24
        public ProduceEventSuggestionType SuggestionType;                 // 32 enum
        public string                   ProduceStoryId;                 // 40
        public string                   ProduceStoryGroupId;            // 48
        public string[]                 ProduceEffectIds;               // 56
        public string[]                 ProduceStepEventSuggestionIds;  // 64
        public string                   SupportCardId;                  // 72
        public ProduceEventType         EventType;                      // 80 enum
        public ProduceEventCharacterType EventCharacterType;             // 84 enum
        public bool                     IsBusinessExcellent;            // 88
        public ProduceDescriptionSegment[] ProduceDescriptions;            // 96
    }
}
