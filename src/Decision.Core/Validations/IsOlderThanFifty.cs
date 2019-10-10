using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public class IsOlderThanFifty : AbstractValidation<Person>
    {
        public override Predicate<Person> Predicate => person => person.Age > 50;
    }
}