using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace ReverseCampus
{
    public class MeishiIllustrationAsset
    {
        public string                   Id;                             // 32
        public MeishiIllustrationType   Type;                           // 40 enum
        public bool                     IsDefault;                      // 44
        public float                    LeftTopPositionX;               // 48
        public float                    LeftTopPositionY;               // 52
        public float                    RightBottomPositionX;           // 56
        public float                    RightBottomPositionY;           // 60
        public string                   Name;                           // 64
        public int                      Weight;                         // 72
        public int                      Height;                         // 76
        public int                      Order;                          // 80
    }
}
