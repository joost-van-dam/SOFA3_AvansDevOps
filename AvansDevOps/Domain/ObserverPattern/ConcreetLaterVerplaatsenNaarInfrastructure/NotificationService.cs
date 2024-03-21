using AvansDevOps.Domain.People;
using AvansDevOps.Infrastructure.Adapters;

namespace AvansDevOps.Domain.ObserverPattern.ConcreetLaterVerplaatsenNaarInfrastructure
{
    internal class NotificationService : IObserver
    {
        private Project project;
        private INotifier emailNotifier = new EmailAdapter();
        private INotifier slackNotifier = new SlackAdapter();


        public NotificationService(Project project)
        {
            this.project = project;
        }

        void IObserver.Update(Notification notification)
        {
            notification.GetTypeOfReceiver();

            if (notification.GetTypeOfReceiver() == TypeOfReceiver.Tester)
            {
                //SendNotification(new List<Person>(this.project.GetTesters().Cast<Person>()));
                SendNotification(new List<Person>(this.project.GetTesters()), notification.GetMessage());
            }
            else if (notification.GetTypeOfReceiver() == TypeOfReceiver.ScrumMasterAndProductOwner)
            {
                SendNotification(new List<Person> { this.project.GetScrumMaster(), this.project.GetProductOwner() }, notification.GetMessage());
            }
        }

        // in deze class komt de logica voor het versturen van de notificaties via het juiste medium

        // hier dus de berichten sturen naar de juiste personen met het juiste medium
        private void SendNotification(List<Person> people, string message)
        {
            // hier kijken voor de voorkeuren van
            foreach (Person person in people)
            {
                // nu doen we nog elk medium
                this.emailNotifier.SendNotification(person, message);
                this.slackNotifier.SendNotification(person, message);
            }


        }





    }
}
