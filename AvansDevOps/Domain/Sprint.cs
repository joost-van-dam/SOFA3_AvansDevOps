using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain
{
    internal abstract class Sprint
    {
        internal string name; //willen we een sprint een naam geven?
        internal DateTime startDate;
        internal DateTime endDate;
        private ScrumMaster scrumMaster;
        private LinkedList<Developer> developers;
        private Backlog backlog;
        private ISprintState sprintState;


        protected Sprint(string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, Backlog backlog, ISprintState sprintState)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.scrumMaster = scrumMaster;
            this.developers = developers;
            this.backlog = backlog;
            this.sprintState = sprintState;
        }

        // hiervan vinden we dat dit voor elke instatie van een sprint is
        public void ChangeName(string name)
        {
            this.sprintState.ChangeName(name);
        }
        public void ChangeStartDate(DateTime startDate)
        {
            this.sprintState.ChangeStartDate(startDate);
        }
        public void ChangeEndDate(DateTime endDate)
        {
            this.sprintState.ChangeEndDate(endDate);
        }

    }
}