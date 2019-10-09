using System.Collections.Generic;
using Decision.Core.Models;

namespace Decision.Core
{
    public class BarTenderService
    {
        private readonly ICollection<Spec<Person, string>> _flows;

        public BarTenderService(ICollection<Spec<Person, string>> flows) =>
            _flows = flows;

        public string ServeDrink(Person person)
        {
            foreach ( var rule in _flows)
                if (rule.Satisfies(person)) return rule.Result;

            return "Water! :'(";
        }
    }
}