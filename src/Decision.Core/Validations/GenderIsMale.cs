using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public class GenderIsMale : AbstractValidation<Person>
    {
        public override Expression<Func<Person, bool>> Rule => person => person.Gender == Gender.Male;
    }
}