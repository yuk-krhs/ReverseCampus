using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public enum ProduceEventCharacterType
    {
        Unknown,
        Opening,
        AfterStep1,
        BeforeAuditionMid1,
        AfterAuditionMid1,
        AfterStep2,
        BeforeAuditionMid2,
        AfterAuditionMid2,
        BeforeAuditionFinal,
        AfterAuditionFinal,
        Failure,
        Ending,
        AfterStepBeforeAuditionMid1,
        AfterStepBeforeAuditionMid2,
        AfterStepBeforeAuditionFinal,
    }
}
