using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public abstract class AbstractValidation<T> : IValidation<T>
    {
        public abstract Predicate<T> Predicate { get; }

        public virtual bool Validate(T item) => Predicate(item);
    }
}