using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ExamSetting
    {
        public string                   Id;                             // 24
        public bool                     AuditionSupportUpgradeAdded;    // 32
        public int                      ExamStaminaConsumptionDownPermil; // 36
        public int                      ExamStaminaConsumptionAddPermil; // 40
        public int                      ExamBlockAddDownPermil;         // 44
        public int                      ExamStaminaConsumptionAddDownPermil; // 48
        public int                      ExamStaminaReduceChange;        // 52
        public int                      ExamStaminaConsumptionDownAddPermil; // 56
        public int                      ExamConcentrationLessonValueMultiplePermil; // 60
        public int                      FullPowerPlayableValueAdd;      // 64
        public int                      ExamFullPowerLessonValueMultiplePermil; // 68
        public int                      HoldLimit;                      // 72
        public int                      HandLimit;                      // 76
        public int                      TurnStartDistribute;            // 80
        public int                      ExamGimmickParameterDebuffPermil; // 84
        public int                      ExamParameterBuffPermil;        // 88
        public int                      ExamTurnEndRecoveryStamina;     // 92
        public int[]                    ProduceExamPanicStaminaCandidates; // 96
        public int                      ExamParameterBuffMultiplePerTurnPermil; // 104
        public int                      PreservationReleasePlayableValueAdd1; // 108
        public int                      PreservationReleasePlayableValueAdd2; // 112
        public int                      PreservationReleaseBlockAdd1;   // 116
        public int                      PreservationReleaseBlockAdd2;   // 120
        public int                      PreservationReleaseEnthusiastic1; // 124
        public int                      PreservationReleaseEnthusiastic2; // 128
        public int                      ExamConcentrationLessonValueMultiplePermil1; // 132
        public int                      ExamConcentrationLessonValueMultiplePermil2; // 136
        public int                      ExamPreservationLessonValueMultiplePermil1; // 140
        public int                      ExamPreservationLessonValueMultiplePermil2; // 144
        public int                      ExamConcentrationStaminaMultiplePermil1; // 148
        public int                      ExamConcentrationStaminaMultiplePermil2; // 152
        public int                      ExamPreservationStaminaMultiplePermil1; // 156
        public int                      ExamPreservationStaminaMultiplePermil2; // 160
        public int                      ExamConcentrationStaminaPenetrateReduce1; // 164
        public int                      ExamConcentrationStaminaPenetrateReduce2; // 168
        public bool                     ExamCardSelectEvaluationTriggerCoefficientEnable; // 172
        public bool                     ExamDrawCountLimitFixed;        // 173
        public int                      ExamAutoPlayEnableVersion;      // 176
        public int                      ExamAutoPlaySearchCommandLimit; // 180
        public int                      OverPreservationReleasePlayableValueAdd; // 184
        public int                      OverPreservationReleaseBlockAdd; // 188
        public int                      OverPreservationReleaseEnthusiastic; // 192
        public int                      ExamOverPreservationLessonValueMultiplePermil; // 196
        public int                      ExamOverPreservationStaminaMultiplePermil; // 200
        public int                      OverPreservationReleaseToFullPowerGrowEffectLessonAdd; // 204
        public int[]                    ExamAutoPlaySearchCommandPlanLimits; // 208
        public bool                     ExamDrinkTriggerFixed;          // 216
        public int                      ExamLessonValueMultipleDependReviewOrAggressiveMultiplePermil; // 220
    }
}
