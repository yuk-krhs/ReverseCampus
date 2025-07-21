using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public enum HomeMotionType
    {
        Unknown,
        Wait1,
        Wait2,
        Reaction,
        ReactionOnce,
        WaitLookAround,
        MultipleTaps,
        Transition,
        WaitOnce,
    }
}
