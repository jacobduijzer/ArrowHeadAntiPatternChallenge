using System;
using Decision.Core.Validations;

namespace Decision.Core.Rules
{
    public class SweetWiteWine : IRule<Person>
    {
        public Predicate<Person> Predicate => person => new IsAdult().Validate(person) &&
                                                        !new GenderIsMale().Validate(person) &&
                                                        !new IsOlderThanThirty().Validate(person);
        public string Result => "Wine";
    }
}