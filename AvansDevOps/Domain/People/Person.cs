namespace AvansDevOps.Domain.People
{
    internal abstract class Person
    {
        private string firstName { get; }
        private string lastName { get; }

        protected Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
