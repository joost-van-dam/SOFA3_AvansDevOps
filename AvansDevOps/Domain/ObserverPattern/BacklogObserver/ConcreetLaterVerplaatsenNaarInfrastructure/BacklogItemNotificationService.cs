using AvansDevOps.Domain.People;
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
                ScrumMaster scrumMaster = backlogItem.GetSprint().GetScrumMaster();
                ProductOwner productOwner = backlogItem.GetSprint().GetProject().GetProductOwner();

                // voorkeuren ophalen
                var scrumasterPreferences = scrumMaster.GetPreferences();
                var productOwnerPreferences = productOwner.GetPreferences();

                foreach (var notifier in notifiers)
                {
                    // matchen of de scrummaster en productowner de notificatie willen ontvangen op dit platform
                    notifier.SendNotification(scrumMaster, $"backlogitem {backlogItem.GetName} of developer {backlogItem.GetDeveloper().GetFirstName()} {backlogItem.GetDeveloper().GetLastName()} has been rejected by the tester");
                    notifier.SendNotification(productOwner, $"backlogitem {backlogItem.GetName} of developer {backlogItem.GetDeveloper().GetFirstName()} {backlogItem.GetDeveloper().GetLastName()} has been rejected by the tester");
                }
            }


            var backlogItemState = backlogItem.GetState();





        }

    }
}
