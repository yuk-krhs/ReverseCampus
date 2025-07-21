using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceStepLessonLevel
    {
        public string                   Id;                             // 24
        public int                      ProgressLevel;                  // 32
        public int                      LimitTurn;                      // 36
        public int                      SuccessThreshold;               // 40
        public int                      ResultTargetValueLimit;         // 44
    }
}
