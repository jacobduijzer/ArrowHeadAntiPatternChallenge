using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public class IsOlderThanFifty : AbstractValidation<Person>
    {
        public override Expression<Func<Person, bool>> Rule => person => person.Age > 50;
    }
}