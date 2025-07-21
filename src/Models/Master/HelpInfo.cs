using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class HelpInfo
    {
        public string                   Type;                           // 24
        public string[]                 HelpCategoryIds;                // 32
        public string                   OpenHelpCategoryId;             // 40
        public string                   OpenHelpContentId;              // 48
    }
}
