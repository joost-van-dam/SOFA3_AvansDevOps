using AvansDevOps.Domain.People;
using AvansDevOps.Infrastructure.Libraries;

namespace AvansDevOps.Infrastructure.Adapters
{
    internal class EmailAdapter
    {
        private EmailLibrary emailLibrary;

        public EmailAdapter()
        {
            this.emailLibrary = new EmailLibrary();
        }

        public void SendEmail(Person person, string subject, string body)
        {
            this.emailLibrary.SendEmail($"@{person.GetEmail}", subject, body);
        }
    }
}
