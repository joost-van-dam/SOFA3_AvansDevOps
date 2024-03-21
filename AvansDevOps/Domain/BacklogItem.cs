using AvansDevOps.Domain.ObserverPattern;
using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States;
using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain
{
    internal class BackLogItem : ISubject
    {
        private string name { get; set; }
        private string description { get; set; }
        private Developer developer { get; set; } // aan Arno vragen hoe het zit met de assignment van een backlogitemactivity aan een andere developer
        private LinkedList<BackLogItemActivity> backLogItemActivities = new LinkedList<BackLogItemActivity>();
        private IBacklogItemState backlogItemState { get; set; }

        private LinkedList<IBacklogItemStateObserver> observers = new LinkedList<IBacklogItemStateObserver>();

        public BackLogItem(string name, string description, Developer developer, LinkedList<BackLogItemActivity> backLogItemActivities)
        {
            this.name = name;
            this.description = description;
            this.developer = developer;
            this.backLogItemActivities = backLogItemActivities;
            this.backlogItemState = new BacklogItemToDoState(this);
        }

        public void AddBacklogItemActivity(BackLogItemActivity backLogItemActivity)
        {
            this.backLogItemActivities.AddLast(backLogItemActivity);
        }

        public void RemoveBacklogItemActivity(BackLogItemActivity backLogItemActivity)
        {
            this.backLogItemActivities.Remove(backLogItemActivity);
        }

        internal void SetState(IBacklogItemState state)
        {
            var oldState = this.backlogItemState;
            this.backlogItemState = state;
            Notify(this, oldState);
        }

        internal IBacklogItemState GetState()
        {
            return this.backlogItemState;
        }

        internal string GetName()
        {
            return this.name;
        }

        internal string GetDeveloperFullName()
        {
            return $"{this.developer.GetFirstName()} {this.developer.GetLastName}";
        }

        // niet implicit op de interface zodat je vanuit de state ook deze functie kan aanroepen
        public void Attach(IBacklogItemStateObserver observer)
        {
            this.observers.AddLast(observer);
        }

        public void Detach(IBacklogItemStateObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify(BackLogItem backlogItem, IBacklogItemState oldState)
        {
            foreach (IBacklogItemStateObserver observer in this.observers)
            {
                observer.Update(backlogItem, oldState);
            }
        }
    }
}