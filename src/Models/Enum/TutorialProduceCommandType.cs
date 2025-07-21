using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public enum TutorialProduceCommandType
    {
        Unknown,
        Start,
        Next,
        StepLessonEnd,
        StepPresentReceive,
        StepAuditionExamEnd,
        StepAuditionEnd,
        CheckBeforeLiveProduceEvaluation,
        Result,
    }
}
