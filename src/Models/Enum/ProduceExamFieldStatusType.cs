using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public enum ProduceExamFieldStatusType
    {
        Unknown,
        ParameterBuff,
        StaminaUpMultiple,
        StaminaLessMultiple,
        StaminaConsumptionDown,
        ConcentrationUp,
        PreservationUp,
        FullPowerUp,
        PlayCardRestriction,
        NoBlock,
        PlayCardSkill,
        PlayCardLesson,
        PlayCardSupport,
        TurnProgressUp,
        ConditionThresholdMultiple,
        ConditionThresholdMultipleDown,
        LessonBuffUp,
        BlockUp,
        ReviewUp,
        GimmickLessonDebuffUp,
        GimmickSleepyUp,
        ParameterBuffUp,
        BlockAddDown,
        GimmickParameterDebuff,
        RemainingTurn,
        CardPlayAggressiveUp,
        ParameterLessThan,
        FullPowerPointUp,
        FullPowerPointGetSumUp,
        NoStance,
        StanceChangeCountUp,
        ConcentrationChangeCountUp,
        PreservationChangeCountUp,
        FullPowerChangeCountUp,
        CardSearchCountUp,
        PlayCardSearch,
        ParameterBuffMultiplePerTurnUp,
        EnthusiasticUp,
    }
}
