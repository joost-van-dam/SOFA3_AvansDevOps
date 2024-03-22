using AvansDevOps.Domain.ObserverPattern;
using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States;
using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain
{
    internal class BacklogItem : IObservableBacklogItem
    {
        private string name { get; set; }
        private string description { get; set; }
        private Developer developer { get; set; } // aan Arno vragen hoe het zit met de assignment van een backlogitemactivity aan een andere developer
        private LinkedList<BacklogItemActivity> backlogItemActivities = new LinkedList<BacklogItemActivity>();
        private IBacklogItemState backlogItemState { get; set; }

        private LinkedList<IBacklogItemObserver> observers = new LinkedList<IBacklogItemObserver>();

        public BacklogItem(string name, string description, Developer developer, LinkedList<BacklogItemActivity> backlogItemActivities)
        {
            this.name = name;
            this.description = description;
            this.developer = developer;
            this.backlogItemActivities = backlogItemActivities;
            this.backlogItemState = new BacklogItemToDoState(this);
        }

        public void AddBacklogItemActivity(BacklogItemActivity backlogItemActivity)
        {
            this.backlogItemActivities.AddLast(backlogItemActivity);
        }

        public void RemoveBacklogItemActivity(BacklogItemActivity backlogItemActivity)
        {
            this.backlogItemActivities.Remove(backlogItemActivity);
        }

        internal void SetState(IBacklogItemState state)
        {
            var oldState = this.backlogItemState;
            this.backlogItemState = state;

            // 1 IF-statement
            // if state creats notification == true
            // in de state defineren of de state een notificatie moet sturen

            // in de backlogitem ligt de verantwoordelijk voor het versturen van de notificatie

            if (backlogItemState.CreatesNotification() == true)
            {
                // verstuur notificatie
                Notify(this, oldState);
            }

        }

        internal IBacklogItemState GetState()
        {
            return this.backlogItemState;
        }

        internal string GetName()
        {
            return this.name;
        }

        // een observer is GEEN persoon maar bijv. een NotificationService, de notification service zoekt dan ook wat er moet gebeuren met de notificatie
        public void Attach(IBacklogItemObserver observer)
        {
            this.observers.AddLast(observer);
        }

        public void Detach(IBacklogItemObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify(BacklogItem backlogItem, IBacklogItemState oldState)
        {
            foreach (IBacklogItemObserver observer in this.observers)
            {
                observer.Update(backlogItem, oldState);
            }
        }
    }
}