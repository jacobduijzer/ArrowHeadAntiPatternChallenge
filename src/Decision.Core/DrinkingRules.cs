using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Decision.Core
{
    public class DrinkingRules
    {
        public readonly ICollection<DrinkingRule> Rules;

        private DrinkingRules() => Rules = new List<DrinkingRule>();

        public static DrinkingRules Init()
        {
            var rules = new DrinkingRules();

            rules.Rules.Add(new DrinkingRule((p) => !( p.Age >= 18 ) && !( p.Gender.Equals(Gender.Male) ) && !( p.HasAdhd ),"Fanta"));
            rules.Rules.Add(new DrinkingRule((p) => !( p.Age >= 18 ) && !( p.Gender.Equals(Gender.Male) ) && ( p.HasAdhd ), "Orange juice"));
            rules.Rules.Add(new DrinkingRule((p) => !(p.Age >= 18) && (p.Gender.Equals(Gender.Male)) && !(p.HasAdhd), "Coke"));
            rules.Rules.Add(new DrinkingRule((p) => !(p.Age >= 18) && (p.Gender.Equals(Gender.Male)) && (p.HasAdhd), "Apple juice"));
            rules.Rules.Add(new DrinkingRule((p) => (p.Age >= 18) && !(p.Gender.Equals(Gender.Male)) && !(p.Age > 30), "Wine"));
            rules.Rules.Add(new DrinkingRule((p) => ( p.Age >= 18 ) && !( p.Gender.Equals(Gender.Male) ) && ( p.Age > 30 ) && !( p.Age > 50 ),"Beer"));
            rules.Rules.Add(new DrinkingRule((p) => ( p.Age >= 18 ) && !( p.Gender.Equals(Gender.Male) ) && ( p.Age > 30 ) && ( p.Age > 50 ),"Wine"));
            rules.Rules.Add(new DrinkingRule((p) => ( p.Age >= 18 ) && ( p.Gender.Equals(Gender.Male) ) && !( p.Age > 50 ), "Beer"));
            rules.Rules.Add(new DrinkingRule((p) => (p.Age >= 18) && (p.Gender.Equals(Gender.Male)) && (p.Age > 50), "Whiskey"));

            return rules;
        }
    }
}