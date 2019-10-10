using System.Collections.Generic;
using Decision.Core.Rules;

namespace Decision.Core
{
    public static class DrinkingRules
    {
        public static IList<IRule<Person>> Rules =>
            new List<IRule<Person>>
            {
                new FantaRule(),
                new OrangeJuiceRule(),
                new CokeRule(),
                new AppleJuiceRule(),
                new SweetWiteWine(),
                new MaleBeerRule(),
                new RedWineRule(),
                new FemaleBeerRule(),
                new WhiskeyRule()
            };
    }
}

