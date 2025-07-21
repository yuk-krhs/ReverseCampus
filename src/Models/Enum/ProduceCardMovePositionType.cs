using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public enum ProduceCardMovePositionType
    {
        Unknown,
        Hand,
        DeckFirst,
        DeckLast,
        DeckRandom,
        Grave,
        Lost,
        Hold,
    }
}
