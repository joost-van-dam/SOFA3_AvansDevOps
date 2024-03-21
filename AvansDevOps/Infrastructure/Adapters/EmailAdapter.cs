using AvansDevOps.Domain.People;
using AvansDevOps.Infrastructure.Libraries;

namespace AvansDevOps.Infrastructure.Adapters
{
    internal class EmailAdapter : INotifier
    {
        private EmailLibrary emailLibrary;

        public EmailAdapter()
        {
            this.emailLibrary = new EmailLibrary();
        }

        //misschien van die message ook een object maken waar je de subject en body in kan zetten voor bijv. een email en voor slack alleen de body gebruiken als bericht
        void INotifier.SendNotification(Person person, string message)
        {
            //this.emailLibrary.SendEmail($"@{person.GetEmail}", subject, body);
            this.emailLibrary.SendEmail($"@{person.GetEmail}", "subject", message);
        }
    }
}
