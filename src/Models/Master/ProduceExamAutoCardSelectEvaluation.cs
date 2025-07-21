using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceExamAutoCardSelectEvaluation
    {
        public ExamPlayType             Type;                           // 24 enum
        public ProduceExamEffectType    ExamEffectType;                 // 28 enum
        public int                      RemainingTerm;                  // 32
        public ProduceExamAutoCardSelectEvaluationType EvaluationType;                 // 36 enum
        public int                      Evaluation;                     // 40
    }
}
