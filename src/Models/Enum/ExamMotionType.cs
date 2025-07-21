using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public enum ExamMotionType
    {
        Unknown,
        ParameterUp,
        ParameterUpLarge,
        BlockAdd,
        Buff,
        Debuff,
        Wait,
        NoMotionUseDrink,
        WaitOnce,
    }
}
