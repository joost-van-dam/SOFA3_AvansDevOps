namespace AvansDevOps.Domain.People
{
    internal class Developer : Person
    {
        private bool isLeadDeveloper;

        public Developer(string firstName, string lastName, string email, List<NotificationPlatformPreferences> preferences, bool isLeadDeveloper) : base(firstName, lastName, email, preferences)
        {
            this.isLeadDeveloper = isLeadDeveloper;
        }
    }
}
