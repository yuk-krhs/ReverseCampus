using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ResultGradePattern
    {
        public ResultGradeType          Type;                           // 24 enum
        public ResultGrade              Grade;                          // 28 enum
        public int                      Threshold;                      // 32
    }
}
