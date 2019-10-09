using System.Collections.Generic;
using Decision.Core.Rules;

namespace Decision.Core
{
    public class BarTenderService
    {
        private readonly ICollection<IRule<Person>> _rules;

        public BarTenderService(ICollection<IRule<Person>> rules) =>
            _rules = rules;

        public string ServeDrink(Person person)
        {
            foreach ( var rule in _rules)
            {
                if (rule.Predicate(person)) return rule.Result;
            }
            return "Water! :'(";
        }
    }
}