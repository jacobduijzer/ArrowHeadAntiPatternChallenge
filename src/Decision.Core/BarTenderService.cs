using Decision.Core.Specifications;

namespace Decision.Core
{
    public class BarTenderService
    {
        public string ServeDrink(Person person)
        {
            // Using guard statements
            var female = !GenderIsMale.Satisfied(person);

            if (HasADHD.Satisfied(person)) {
                return $"{female ? "Orange" : "Apple"} juice";
            }

            if (!OlderThanEighteen.Satisfied(person)) {
                return female ? "Fanta" : "Coke";
            }

            if (OlderThanFifty.Satisfied(person)) {
                return female ? "Wine" : "Whiskey";
            }
            return female && !OlderThanThirty.Satisfied(person) ? "Wine" : "Beer";
        }
    }
}