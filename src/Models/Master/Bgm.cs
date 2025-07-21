using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class Bgm
    {
        public string                   Page;                           // 24
        public string                   Name;                           // 32
        public string                   BgmAssetId;                     // 40
        public int                      Order;                          // 48
        public long                     ViewStartTime;                  // 56
        public long                     ViewEndTime;                    // 64
    }
}
