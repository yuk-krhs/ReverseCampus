using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceExamAutoEvaluation
    {
        public ExamPlayType             Type;                           // 24 enum
        public ProduceExamEffectType    ExamEffectType;                 // 28 enum
        public int                      RemainingTerm;                  // 32
        public ProduceExamAutoEvaluationType EvaluationType;                 // 36 enum
        public int                      Evaluation;                     // 40
        public int                      ExamStatusEnchantCoefficientPermil; // 44
    }
}
