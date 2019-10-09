using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public class IsOlderThanThirty : AbstractValidation<Person>
    {
        public override Expression<Func<Person, bool>> Rule => person => person.Age > 30;
    }
}