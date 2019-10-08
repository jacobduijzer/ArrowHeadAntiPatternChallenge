namespace Decision.Core.Specifications
{
    public class HasAdhd : AbstractSpecification<Person>
    {
        public override bool IsSatisfied(Person person) => person.HasAdhd;
    }
}