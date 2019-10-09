using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public interface IValidation<T>
    {
        Expression<Func<T, bool>> Rule { get; }

        bool Validate(T item);
    }
}