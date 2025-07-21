using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public enum GashaLimitType
    {
        Unknown,
        None,
        Total,
        Daily,
        DailyAccumulation,
        DailyLoginAccumulation,
    }
}
