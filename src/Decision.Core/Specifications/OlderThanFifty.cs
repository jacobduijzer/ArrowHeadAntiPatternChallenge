namespace Decision.Core.Specifications
{
    public class OlderThanFifty : AbstractSpecification<Person>
    {
        public override bool IsSatisfied(Person person) => person.Age > 50;
        public static bool Satisfied(Person person) => new OlderThanFifty().IsSatisfied(person);
    }
}