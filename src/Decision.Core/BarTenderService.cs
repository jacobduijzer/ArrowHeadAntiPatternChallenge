using System.Collections.Generic;

namespace Decision.Core
{
    public class BarTenderService
    {
        private readonly ICollection<DrinkingRule> _drinkingRules;

        public BarTenderService(ICollection<DrinkingRule> drinkingRules) =>
            _drinkingRules = drinkingRules;

        public string ServeDrink(Person person)
        {
            foreach ( var rule in _drinkingRules)
            {
                if (rule.Predicate(person)) return rule.Drink;
            }
            return "Water! :'(";
        }
    }
}