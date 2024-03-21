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

        void IObserver.Update()
        {

            project.GetDeveloperList();
            throw new NotImplementedException();
        }

        // in deze class komt de logica voor het versturen van de notificaties via het juiste medium

        // hier dus de berichten sturen naar de juiste personen met het juiste medium





    }
}
