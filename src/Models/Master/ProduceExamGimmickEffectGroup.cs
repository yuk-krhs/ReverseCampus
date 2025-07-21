using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ProduceExamGimmickEffectGroup
    {
        public string                   Id;                             // 24
        public int                      Priority;                       // 32
        public int                      RemainingTurnPermil;            // 36
        public int                      StartTurn;                      // 40
        public int                      RemainingTurn;                  // 44
        public ProduceExamFieldStatusType FieldStatusType;                // 48 enum
        public int                      FieldStatusValue;               // 52
        public ProduceExamTriggerCheckType FieldStatusCheckType;           // 56 enum
        public string                   ProduceExamEffectId;            // 64
        public bool                     IsPositive;                     // 72
        public ProduceDescriptionSegment[] ProduceDescriptions;            // 80
    }
}
