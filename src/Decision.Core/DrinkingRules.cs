using System.Collections.Generic;
using Decision.Core.Rule;

namespace Decision.Core
{
    public static class DrinkingRules
    {
        public static IList<IRule<PersonState>> Rules =>
            new List<IRule<PersonState>>
            {
                new FantaRule(),
                new OrangeJuiceRule(),
                new CokeRule(),
                new AppleJuiceRule(),
                new FemaleBeerRule(),
                new OlderFemaleWineRule(),
                new YoungerFemaleWineRule(),
                new MaleBeerRule(),
                new WhiskeyRule()
            };
    }
}