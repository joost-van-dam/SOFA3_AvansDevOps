using AvansDevOps.Domain.People;
using AvansDevOps.Domain.Stategies;
using AvansDevOps.Domain.Stategies.Abstracts;
using AvansDevOps.Domain.States;
using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain
{
    internal class Sprint
    {
        internal string name; //willen we een sprint een naam geven?
        internal DateTime startDate;
        internal DateTime endDate;
        private ScrumMaster scrumMaster;
        private LinkedList<Developer> developers;
        private Backlog backlog;
        private ISprintState sprintState;
        private ISprintTypeStrategy sprintTypeStrategy;


        public Sprint(string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, Backlog backlog)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.scrumMaster = scrumMaster;
            this.developers = developers;
            this.backlog = backlog;
            this.sprintState = new SprintCreatedState(this);
            this.sprintTypeStrategy = new PartialProductSprintTypeStrategy(); // is nu even de default
        }

        public void SwitchSprintTypeStrategy(ISprintTypeStrategy sprintTypeStrategy)
        {
            this.sprintTypeStrategy = sprintTypeStrategy;
        }

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