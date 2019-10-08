using Decision.Core.Extensions;
using Decision.Core.Specifications;

namespace Decision.Core
{
    public class BarTenderService
    {
        public string ServeDrink(Person person)
        {
            PersonState personType = 0;

            if (person.IsEighteenOrOlder())
                personType = PersonState.EighteenOrOlder;

            if (person.IsThirtyOrOlder())
                personType = PersonState.ThirtyOrOlder;

            if (person.IsFiftyOrOlder())
                personType = PersonState.FiftyOrOlder;

            if (person.IsMale())
                personType |= PersonState.Male;

            if (person.HasAdhdDisorder())
                personType |= PersonState.HasAdhd;

            DrinkType type = (DrinkType) personType;

            return type.ToString();
        }
    }
}