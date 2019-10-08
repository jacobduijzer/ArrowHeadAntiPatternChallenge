namespace Decision.Core.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}