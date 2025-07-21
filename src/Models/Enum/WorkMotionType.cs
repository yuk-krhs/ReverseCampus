using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public enum WorkMotionType
    {
        Unknown,
        CharacterSelectWait,
        CharacterSelectReaction,
        StartNormal,
        StartFine,
        FinishNormal,
        FinishExcellent,
    }
}
