using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class HomeTime
    {
        public int                      StartHour;                      // 24
        public int                      StartMinute;                    // 28
        public HomeTimeType             Type;                           // 32 enum
    }
}
