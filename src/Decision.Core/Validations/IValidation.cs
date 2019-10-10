using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public interface IValidation<T>
    {
        Predicate<T> Predicate { get; }
        bool Validate(T item);
    }
}