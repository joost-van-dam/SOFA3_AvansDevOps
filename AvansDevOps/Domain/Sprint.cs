using AvansDevOps.Domain.People;
using AvansDevOps.Domain.Stategies;
using AvansDevOps.Domain.Stategies.Abstracts;
using AvansDevOps.Domain.States;
using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain
{
    internal class Sprint
    {
        private string name; //willen we een sprint een naam geven?
        private DateTime startDate;
        private DateTime endDate;
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
            this.sprintState = new SprintCreatedState();
            this.sprintTypeStrategy = new PartialProductSprintTypeStrategy(this);

        }
    }
}