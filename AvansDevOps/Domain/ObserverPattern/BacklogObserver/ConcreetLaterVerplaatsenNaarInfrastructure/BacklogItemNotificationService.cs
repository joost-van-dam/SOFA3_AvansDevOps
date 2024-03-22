using AvansDevOps.Domain.States;
using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Infrastructure.Adapters;

namespace AvansDevOps.Domain.ObserverPattern.BacklogObserver.ConcreetLaterVerplaatsenNaarInfrastructure
{
    internal class BacklogItemNotificationService : IBacklogItemObserver
    {
        private Project project;

        private List<INotifier> notifiers = new List<INotifier>();


        public BacklogItemNotificationService(Project project, List<INotifier> notifiers)
        {
            this.project = project;
            this.notifiers = notifiers;
        }

        // de melding van de state change komt hier binnen
        void IBacklogItemObserver.Update(BacklogItem backlogItem, IBacklogItemState oldState)
        {

            //notificatie naar scrummaster en productowner omdat backlogitem is afgekeurd is door tester
            if (backlogItem.GetState() is BacklogItemToDoState && oldState is BacklogItemTestingState)
            {
                // ophalen van de scrummaster en productowner

                // voorkeuren ophalen

                // versturen van de notificatie
            }


            var backlogItemState = backlogItem.GetState();





        }














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

        // in deze class komt de logica voor het versturen van de notificaties via het juiste medium

        // hier dus de berichten sturen naar de juiste personen met het juiste medium





    }
}
