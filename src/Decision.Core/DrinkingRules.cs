using System.Collections.Generic;
using Decision.Core.Rules;

namespace Decision.Core
{
    public class DrinkingRules
    {
        public readonly List<IRule<Person>> Rules;

        private DrinkingRules() => Rules = new List<IRule<Person>>();

        public static DrinkingRules Init()
        {
            var rules = new DrinkingRules();
            rules.Rules.AddRange(new List<IRule<Person>>
            {
                new FantaRule(),
                new OrangeJuiceRule(),
                new CokeRule(),
                new SweetWiteWine(),
                new MaleBeerRule(),
                new RedWineRule(),
                new FemaleBeerRule()
            });

            return rules;
        }
    }
}

