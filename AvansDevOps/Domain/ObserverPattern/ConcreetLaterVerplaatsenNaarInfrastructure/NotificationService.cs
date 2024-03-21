namespace AvansDevOps.Domain.ObserverPattern.ConcreetLaterVerplaatsenNaarInfrastructure
{
    internal class NotificationService : IObserver
    {
        private Project project;

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


    }
}
