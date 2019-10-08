using Decision.Core.Specifications;

namespace Decision.Core
{
    public class BarTenderService
    {
        public string ServeDrink(Person person)
        {
            if (new OlderThanEighteen().And(new GenderIsMale()).And(new OlderThanFifty()).IsSatisfied(person))
            {
                return "Whiskey";
            }
            else if (new OlderThanEighteen().And(new GenderIsMale()).AndNot(new OlderThanFifty()).IsSatisfied(person))
            {
                return "Beer";
            }
            else if (new OlderThanEighteen().AndNot(new GenderIsMale()).And(new OlderThanThirty()).And(new OlderThanFifty()).IsSatisfied(person))
            {
                return "Wine";
            }
            else if (new OlderThanEighteen().AndNot(new GenderIsMale()).And(new OlderThanThirty()).AndNot(new OlderThanFifty()).IsSatisfied(person))
            {
                return "Beer";
            }
            else if (new OlderThanEighteen().AndNot(new GenderIsMale()).AndNot(new OlderThanThirty()).IsSatisfied(person))
            {
                return "Wine";
            }
            else if (!new OlderThanEighteen().IsSatisfied(person) && new GenderIsMale().And(new HasADHD()).IsSatisfied(person))
            {
                return "Apple juice";
            }
            else if (!new OlderThanEighteen().IsSatisfied(person) && new GenderIsMale().AndNot(new HasADHD()).IsSatisfied(person))
            {
                return "Coke";
            }
            else if (!new OlderThanEighteen().IsSatisfied(person) && !new GenderIsMale().IsSatisfied(person) && new HasADHD().IsSatisfied(person))
            {
                return "Orange juice";
            }
            else if (!new OlderThanEighteen().IsSatisfied(person) && !new GenderIsMale().IsSatisfied(person) && !new HasADHD().IsSatisfied(person))
            {
                return "Fanta";
            }

            return "Unknown";
        }
    }
}