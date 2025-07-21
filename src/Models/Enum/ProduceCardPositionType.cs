using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public enum ProduceCardPositionType
    {
        Unknown,
        None,
        Hand,
        Deck,
        Grave,
        Lost,
        DeckAll,
        RandomPool,
        Playing,
        PlayHand,
        Target,
        Self,
        Hold,
        DeckGrave,
    }
}
