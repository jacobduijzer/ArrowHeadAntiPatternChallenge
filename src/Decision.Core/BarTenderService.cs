using Decision.Core.Specifications;

namespace Decision.Core
{
    public class BarTenderService
    {
        public string ServeDrink(Person person)
        {
            if (OlderThanEighteen.Satisfied(person))
            {
                if (GenderIsMale.Satisfied(person))
                {
                    if (OlderThanFifty.Satisfied(person))
                    {
                        return "Whiskey";
                    }
                    else
                    {
                        return "Beer";
                    }
                }
                else
                {
                    if (YoungerThanThirty.Satisfied(person))
                    {
                        return "Wine";
                    }
                    else
                    {
                        if (OlderThanFifty.Satisfied(person))
                        {
                            return "Wine";
                        }
                        else
                        {
                            return "Beer";
                        }
                    }
                }
            }
            else
            {
                if (GenderIsMale.Satisfied(person))
                {
                    if (HasADHD.Satisfied(person))
                    {
                        return "Apple juice";
                    }
                    else
                    {
                        return "Coke";
                    }
                }
                else
                {
                    if (HasADHD.Satisfied(person))
                    {
                        return "Orange juice";
                    }
                    else
                    {
                        return "Fanta";
                    }
                }
            }
        }
    }
}