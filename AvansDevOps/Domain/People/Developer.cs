namespace AvansDevOps.Domain.People
{
    internal class Developer : Person
    {
        private bool isLeadDeveloper;

        public Developer(string firstName, string lastName, bool isLeadDeveloper) : base(firstName, lastName)
        {
            this.isLeadDeveloper = isLeadDeveloper;
        }
    }
}
