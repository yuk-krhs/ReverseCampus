using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class PvpRateUnitSlotUnlock
    {
        public PvpRateGrade             Grade;                          // 24 enum
        public int[]                    SlotCountPerStage;              // 32
    }
}
