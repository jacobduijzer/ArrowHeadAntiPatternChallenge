using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public class IsOlderThanThirty : AbstractValidation<Person>
    {
        public override Predicate<Person> Predicate => person => person.Age > 30;
    }
}