namespace AvansDevOps.Domain.People
{
    internal class Developer : Person
    {
        private bool isLeadDeveloper;

        public Developer(string firstName, string lastName, string email, bool isLeadDeveloper) : base(firstName, lastName, email)
        {
            this.isLeadDeveloper = isLeadDeveloper;
        }
    }
}
