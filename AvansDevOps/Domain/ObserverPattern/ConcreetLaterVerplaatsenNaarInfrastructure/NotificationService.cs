using AvansDevOps.Domain.States;
using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Infrastructure.Adapters;

namespace AvansDevOps.Domain.ObserverPattern.ConcreetLaterVerplaatsenNaarInfrastructure
{
    internal class NotificationService : IBacklogItemStateObserver
    {
        private Project project;

        private List<INotifier> notifiers = new List<INotifier>();


        public NotificationService(Project project, List<INotifier> notifiers)
        {
            this.project = project;
            this.notifiers = notifiers;
        }

        void IBacklogItemStateObserver.Update(BackLogItem backlogItem, IBacklogItemState oldState)
        {

            if (backlogItem.GetState() is BacklogItemToDoState && oldState is BacklogItemTestingState)
            {
                //notificatie naar scrummaster en productowner
            }

            var backlogItemState = backlogItem.GetState();
            //if (backlogItem.GetState() == tyoBacklogItemTestingState




            //notification.GetTypeOfReceiver();

            //if (notification.GetTypeOfReceiver() == TypeOfReceiver.Tester)
            //{
            //    //SendNotification(new List<Person>(this.project.GetTesters().Cast<Person>()));
            //    SendNotification(new List<Person>(this.project.GetTesters()), notification.GetMessage());
            //}
            //else if (notification.GetTypeOfReceiver() == TypeOfReceiver.ScrumMasterAndProductOwner)
            //{
            //    SendNotification(new List<Person> { this.project.GetScrumMaster(), this.project.GetProductOwner() }, notification.GetMessage());
            //}
        }

        // in deze class komt de logica voor het versturen van de notificaties via het juiste medium

        // hier dus de berichten sturen naar de juiste personen met het juiste medium





    }
}
