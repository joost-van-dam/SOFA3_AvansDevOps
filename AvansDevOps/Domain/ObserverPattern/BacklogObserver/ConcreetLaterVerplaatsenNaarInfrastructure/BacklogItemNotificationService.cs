using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Domain.States.BacklogItemStates;
using AvansDevOps.Infrastructure.Adapters;

namespace AvansDevOps.Domain.ObserverPattern.BacklogObserver.ConcreetLaterVerplaatsenNaarInfrastructure
{
    internal class BacklogItemNotificationService : IBacklogItemObserver
    {
        private readonly Project project;

        private readonly List<INotifier> notifiers = new List<INotifier>();


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

















    }
}
