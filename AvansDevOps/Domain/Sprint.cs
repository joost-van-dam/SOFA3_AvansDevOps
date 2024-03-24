using AvansDevOps.Domain.ObserverPattern.SprintObserver;
using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Domain.Strategy;
using AvansDevOps.Domain.Strategy.Abstracts;

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
        private readonly LinkedList<ISprintObserver> observers = new LinkedList<ISprintObserver>();
        private ISprintRapportExportStrategy sprintRapportExportStrategy;


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
            this.sprintRapportExportStrategy = new SprintPDFRapportExportStrategy(); //default
        }

        protected Sprint(Project project, string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, LinkedList<Tester> testers)
        {
            this.project = project;
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.scrumMaster = scrumMaster;
            this.developers = developers;
            this.testers = testers;
            this.backlog = new LinkedList<BacklogItem>();
            this.sprintRapportExportStrategy = new SprintPDFRapportExportStrategy(); //default
        }

        internal void AddBacklogItem(BacklogItem backlogItem)
        {
            this.backlog.AddLast(backlogItem);
        }

        internal void RemoveBacklogItem(BacklogItem backlogItem)
        {
            this.backlog.Remove(backlogItem);
        }

        internal ISprintRapportExportStrategy GetSprintRapportExportStrategy()
        {
            return this.sprintRapportExportStrategy;
        }

        internal void ChangeSprintRapportExportStrategy(ISprintRapportExportStrategy sprintRapportExportStrategy)
        {
            this.sprintRapportExportStrategy = sprintRapportExportStrategy;

        }

        internal void ExportSprintRapport()
        {
            this.sprintRapportExportStrategy.ExportSprintRapport(this);
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

        internal Project GetProject()
        {
            return this.project;
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
        //public void Notify(Sprint sprint, ISprintState oldState)
        //{
        //    foreach (IBacklogItemObserver observer in this.observers)
        //    {
        //        observer.Update(sprint, oldState);
        //    }
        //}
        public abstract void Notify(Sprint sprint, ISprintState oldState);
    }
}