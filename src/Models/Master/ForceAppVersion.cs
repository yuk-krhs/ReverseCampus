using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class ForceAppVersion
    {
        public PlatformType             PlatformType;                   // 24 enum
        public int                      MajorVersion;                   // 28
        public int                      MinorVersion;                   // 32
        public int                      PatchVersion;                   // 36
    }
}
