using System.Collections.Generic;
using Decision.Core.Extensions;
using Decision.Core.Rule;

namespace Decision.Core
{
    public class BarTenderService
    {
        private readonly IList<IRule<PersonState>> _rules;

        public BarTenderService(IList<IRule<PersonState>> rules) =>
            _rules = rules;

        public string ServeDrink(Person person)
        {
            PersonState personType = 0;

            if (person.IsEighteenOrOlder())
                personType |= PersonState.EighteenOrOlder;

            if (person.IsThirtyOrOlder())
                personType |= PersonState.ThirtyOrOlder;

            if (person.IsFiftyOrOlder())
                personType |= PersonState.FiftyOrOlder;

            if (person.IsMale())
                personType |= PersonState.Male;

            if (person.HasAdhdDisorder())
                personType |= PersonState.HasAdhd;

            foreach ( var rule in _rules)
            {
                if (rule.Predicate(personType)) return rule.Result;
            }
            return "Water! :'(";
        }
    }
}