using AvansDevOps.Domain.ObserverPattern.BacklogObserver;
using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Domain.States.BacklogItemActivityStates;
using AvansDevOps.Domain.States.BacklogItemStates;

namespace AvansDevOps.Domain
{
    internal class BacklogItem : IObservableBacklogItem
    {
        private Sprint sprint;
        private string name { get; set; }
        private string description { get; set; }
        private Developer developer { get; set; }
        private readonly LinkedList<BacklogItemActivity> backlogItemActivities = new LinkedList<BacklogItemActivity>();
        private IBacklogItemState backlogItemState { get; set; }

        private readonly LinkedList<IBacklogItemObserver> observers = new LinkedList<IBacklogItemObserver>();

        public BacklogItem(Sprint sprint, string name, string description, Developer developer, LinkedList<BacklogItemActivity> backlogItemActivities)
        {
            this.sprint = sprint;
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

        internal void SetTodoState()
        {
            this.backlogItemState.SetTodoStatus();
        }

        internal void SetDoingState()
        {
            this.backlogItemState.SetDoingStatus();
        }

        internal void SetReadyForTestingState()
        {
            this.backlogItemState.SetReadyForTestingStatus();
        }

        internal void SetTestingState()
        {
            this.backlogItemState.SetTestingStatus();
        }

        internal void SetTestedState()
        {
            this.backlogItemState.SetTestedStatus();
        }

        internal void SetDoneState()
        {
            this.backlogItemState.SetDoneStatus();
        }

        public Sprint GetSprint()
        {
            return this.sprint;
        }

        public Developer GetDeveloper()
        {
            return this.developer;
        }

        internal void SetState(IBacklogItemState state)
        {
            var oldState = this.backlogItemState;
            this.backlogItemState = state;

            // 1 IF-statement
            // if state creats notification == true
            // in de state defineren of de state een notificatie moet sturen

            // in de backlogitem ligt de verantwoordelijk voor het versturen van de notificatie

            if (backlogItemState.CreatesNotification())
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

        internal bool CheckIfAllActivitiesAreDone()
        {
            return this.backlogItemActivities.All(backlogItemActivity => backlogItemActivity.GetState() is BacklogItemActivityDoneState);
        }


        // een observer is GEEN persoon maar bijv. een NotificationService, de notification service zoekt dan ook wat er moet gebeuren met de notificatie
        public void Subscribe(IBacklogItemObserver observer)
        {
            this.observers.AddLast(observer);
        }

        public void Unsubscribe(IBacklogItemObserver observer)
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