using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceExamAutoTriggerEvaluation
    {
        public ExamPlayType             Type;                           // 24 enum
        public string                   ExamStatusEnchantProduceExamTriggerId; // 32
        public int                      CoefficientPermil;              // 40
        public int                      Count;                          // 44
    }
}
