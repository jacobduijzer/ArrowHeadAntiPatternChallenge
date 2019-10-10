using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public class GenderIsMale : AbstractValidation<Person>
    {
        public override Predicate<Person> Predicate => person => person.Gender == Gender.Male;
    }
}