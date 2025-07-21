using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class EventLabel
    {
        public EventType                EventType;                      // 24 enum
        public string                   Name;                           // 32
        public string                   Color;                          // 40
    }
}
