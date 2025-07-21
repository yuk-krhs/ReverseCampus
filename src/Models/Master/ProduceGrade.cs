using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceGrade
    {
        public string                   ProduceGroupId;                 // 24
        public ResultGrade              Grade;                          // 32 enum
        public int                      Threshold;                      // 36
    }
}
