using System;
using Decision.Core.Validations;

namespace Decision.Core.Rules
{
    public class FantaRule : IRule<Person>
    {
        public Predicate<Person> Predicate =>
            (person) => !new IsAdult().Validate(person) &&
                        !new GenderIsMale().Validate(person) &&
                        !new HasAdhd().Validate(person);

        public string Result => "Fanta";
    }
}