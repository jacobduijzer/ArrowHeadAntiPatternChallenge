using System;

namespace Decision.Core
{
    [Flags]
    public enum PersonState
    {
        EighteenOrOlder = 1,
        ThirtyOrOlder = 2,
        FiftyOrOlder = 4,
        HasAdhd = 8,
        Male = 16,
    }
}