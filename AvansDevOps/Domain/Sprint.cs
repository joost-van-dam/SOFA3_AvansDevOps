using AvansDevOps.Domain.ObserverPattern.SprintObserver;
using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain
{
    internal abstract class Sprint : IObservableSprint
    {
        internal Project project;
        internal string name; //willen we een sprint een naam geven?
        internal DateTime startDate;
        internal DateTime endDate;
        private ScrumMaster scrumMaster;
        private LinkedList<Developer> developers;
        private LinkedList<Tester> testers;
        private LinkedList<BacklogItem> backlog;
        private LinkedList<ISprintObserver> observers = new LinkedList<ISprintObserver>();


        protected Sprint(Project project, string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, LinkedList<Tester> testers, LinkedList<BacklogItem> backlog)
        {
            this.project = project;
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.scrumMaster = scrumMaster;
            this.developers = developers;
            this.testers = testers;
            this.backlog = backlog;
        }

        internal LinkedList<Developer> GetDevelopers()
        {
            return this.developers;
        }
        internal LinkedList<Tester> GetTesters()
        {
            return this.testers;
        }

        internal ScrumMaster GetScrumMaster()
        {
            return this.scrumMaster;
        }

        public void Subscribe(ISprintObserver observer)
        {
            this.observers.AddLast(observer);
        }

        public void Unsubscribe(ISprintObserver observer)
        {
            this.observers.Remove(observer);
        }

        // moeten dit abstacte methodes zijn of gewoon normale methodes?
        //public void Notify(Sprint sprint, ISprintState newState)
        //{
        //    foreach (IBacklogItemObserver observer in this.observers)
        //    {
        //        observer.Update(sprint, oldState);
        //    }
        //}
        public abstract void Notify(Sprint sprint, ISprintState newState);
    }
}