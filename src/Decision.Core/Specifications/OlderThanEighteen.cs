namespace Decision.Core.Specifications
{
    public class OlderThanEighteen : AbstractSpecification<Person>
    {
        public override bool IsSatisfied(Person person) => person.Age >= 18;
        public static bool Satisfied(Person person) => new OlderThanEighteen().IsSatisfied(person);
    }
}