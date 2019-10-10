using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public class HasAdhd : AbstractValidation<Person>
    {
        public override Predicate<Person> Predicate => person => person.HasAdhd;
    }
}