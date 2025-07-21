using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class CharacterTrueEndAchievement
    {
        public string                   CharacterId;                    // 24
        public ProduceType              ProduceType;                    // 32 enum
        public Achievement              TrueEndAchievement;             // 40 class
        public Achievement[]            TargetAchievements;             // 48
    }
}
