using System.Collections.Generic;

namespace Decision.Core
{
    public class BarTenderService
    {
        private readonly ICollection<DrinkingRule> _rules;

        public BarTenderService(ICollection<DrinkingRule> rules) =>
            _rules = rules;

        public string ServeDrink(Person person)
        {
            foreach ( var rule in _rules)
            {
                if (rule.Predicate(person)) return rule.Drink;
            }
            return "Water! :'(";
        }
    }
}