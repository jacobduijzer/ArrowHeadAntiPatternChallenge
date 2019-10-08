namespace Decision.Core.Specifications
{
    public class OlderThanThirty : AbstractSpecification<Person>
    {
        public override bool IsSatisfied(Person person) => person.Age > 30;
    }
}