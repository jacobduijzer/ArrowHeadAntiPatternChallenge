using System;

namespace Decision.Core.Specifications
{
    [Flags]
    public enum PersonState
    {
        EighteenOrOlder = 1,
        ThirtyOrOlder = 3,
        FiftyOrOlder = 5,
        HasAdhd = 8,
        Male = 16,
    }

    public enum DrinkType
    {
        Fanta = 0,
        OrangeJuice = PersonState.HasAdhd,
        Coke = PersonState.Male,
        AppleJuice = PersonState.Male | PersonState.HasAdhd,
        SweetWhiteWine = PersonState.EighteenOrOlder,
        FruitBeer = PersonState.ThirtyOrOlder,
        RedWine = PersonState.FiftyOrOlder,
        Beer = PersonState.EighteenOrOlder | PersonState.Male,
        Whiskey = PersonState.EighteenOrOlder | PersonState.Male | PersonState.FiftyOrOlder
    }
}