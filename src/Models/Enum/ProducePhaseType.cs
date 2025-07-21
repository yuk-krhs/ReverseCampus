using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public enum ProducePhaseType
    {
        Unknown,
        RecoveryStamina,
        CustomizeProduceCard,
        GetProducePoint,
        GetProduceItem,
        GetProduceDrink,
        UseProduceDrink,
        GetProduceCard,
        UpgradeProduceCard,
        DeleteProduceCard,
        ProduceStart,
        StartStep,
        StartCustomize,
        StartShop,
        StartRefresh,
        StartPresent,
        StartLesson,
        EndLessonBeforePresent,
        EndLesson,
        FailedLesson,
        EndStepEventActivity,
        EndStepEventSchool,
        EndStepEventCharacterOpening,
        ChangeProduceCard,
        EndStepEventBusiness,
        EndBeforeAuditionRefresh,
        StartAuditionMid,
        StartAuditionMid1,
        StartAuditionMid2,
        StartAuditionFinal,
        StartAudition,
        EndAuditionMid,
        EndAuditionMid1,
        EndAuditionMid2,
        EndAuditionFinal,
        EndAudition,
        BuyShopItem,
        BuyShopItemProduceCard,
        BuyShopItemProduceDrink,
        BuyShopItemProduceItem,
        BuyShopItemUpgradeProduceCard,
        BuyShopItemDeleteProduceCard,
        EndPresent,
        EndShop,
    }
}
