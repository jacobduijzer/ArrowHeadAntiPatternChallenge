using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public class HasAdhd : AbstractValidation<Person>
    {
        public override Expression<Func<Person, bool>> Rule => person => person.HasAdhd;
    }
}