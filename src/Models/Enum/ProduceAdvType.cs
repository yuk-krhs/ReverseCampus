using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public enum ProduceAdvType
    {
        Unknown,
        BeforeFinalLessonHard,
        BeforeMid1LessonHard,
        BeforeMid2LessonHard,
        BeforeFinalAuditionRefresh,
        BeforeMid1AuditionRefresh,
        BeforeMid2AuditionRefresh,
        BeforeFinalAuditionSelect,
        BeforeMid1AuditionSelect,
        BeforeMid2AuditionSelect,
        Introduction,
        StepSkip,
        Opening,
        ProduceResultTrueEnd,
        ProduceResultA,
        ProduceResultB,
        ProduceResultC,
        ProduceResultFailedFinal,
        ProduceResultFailedMid1,
        ProduceResultFailedMid2,
    }
}
