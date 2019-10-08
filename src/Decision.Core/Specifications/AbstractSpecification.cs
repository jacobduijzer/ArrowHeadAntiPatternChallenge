namespace Decision.Core.Specifications
{
    public abstract class AbstractSpecification<T> : ISpecification<T>
    {
        public abstract bool IsSatisfied(T item);
    }
}