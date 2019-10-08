namespace Decision.Core.Specifications
{
    public class OlderThanEighteen : AbstractSpecification<Person>
    {
        public override bool IsSatisfied(Person person) => person.Age >= 18;
    }
}