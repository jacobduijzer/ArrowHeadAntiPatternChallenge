using System;
using System.Linq.Expressions;

namespace Decision.Core.Validations
{
    public abstract class AbstractValidation<T> : IValidation<T>
    {
        public abstract Expression<Func<T, bool>> Rule { get; }

        public virtual bool Validate(T item) => Rule.Compile().Invoke(item);
    }
}