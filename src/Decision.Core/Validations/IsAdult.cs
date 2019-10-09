using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public class IsAdult : AbstractValidation<Person>
    {
        public override Expression<Func<Person, bool>> Rule => person => person.Age >= 18;
    }
}