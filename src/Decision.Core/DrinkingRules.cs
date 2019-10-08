using System.Collections.Generic;
using Decision.Core.Specifications;

namespace Decision.Core
{
    public class DrinkingRules
    {
        public readonly ICollection<DrinkingRule> Rules;

        private DrinkingRules() => Rules = new List<DrinkingRule>();

        public static DrinkingRules Init()
        {
            var rules = new DrinkingRules();
            rules.Rules.Add(new DrinkingRule((person) => !new OlderThanEighteen().IsSatisfied(person) && !new GenderIsMale().IsSatisfied(person) && !new HasAdhd().IsSatisfied(person), "Fanta"));
            rules.Rules.Add(new DrinkingRule((person) => !new OlderThanEighteen().IsSatisfied(person) && !new GenderIsMale().IsSatisfied(person) && new HasAdhd().IsSatisfied(person), "Orange juice"));
            rules.Rules.Add(new DrinkingRule((person) => !new OlderThanEighteen().IsSatisfied(person) && new GenderIsMale().AndNot(new HasAdhd()).IsSatisfied(person), "Coke"));
            rules.Rules.Add(new DrinkingRule((person) => !new OlderThanEighteen().IsSatisfied(person) && new GenderIsMale().And(new HasAdhd()).IsSatisfied(person), "Apple juice"));
            rules.Rules.Add(new DrinkingRule((person) => new OlderThanEighteen().AndNot(new GenderIsMale()).AndNot(new OlderThanThirty()).IsSatisfied(person), "Wine"));
            rules.Rules.Add(new DrinkingRule((person) => new OlderThanEighteen().AndNot(new GenderIsMale()).And(new OlderThanThirty()).AndNot(new OlderThanFifty()).IsSatisfied(person), "Beer"));
            rules.Rules.Add(new DrinkingRule((person) => new OlderThanEighteen().AndNot(new GenderIsMale()).And(new OlderThanThirty()).And(new OlderThanFifty()).IsSatisfied(person), "Wine"));
            rules.Rules.Add(new DrinkingRule((person) => new OlderThanEighteen().And(new GenderIsMale()).AndNot(new OlderThanFifty()).IsSatisfied(person), "Beer"));
            rules.Rules.Add(new DrinkingRule((person) => new OlderThanEighteen().And(new GenderIsMale()).And(new OlderThanFifty()).IsSatisfied(person), "Whiskey"));
            return rules;
        }
    }
}

