using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class CharacterPushMessage
    {
        public string                   CharacterId;                    // 24
        public PushType                 Type;                           // 32 enum
        public int                      Number;                         // 36
        public string                   Title;                          // 40
        public string                   Message;                        // 48
    }
}
