using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States;
using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain
{
    internal class PartialProductSprint : Sprint
    {
        private IPartialProductSprintState sprintState;
        public PartialProductSprint(string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, Backlog backlog) : base(name, startDate, endDate, scrumMaster, developers, backlog/*, new PartialProductSprintCreatedState()*/)
        {
            this.sprintState = new PartialProductSprintCreatedState(this);
        }

        public void StartSprint()
        {
            this.sprintState.StartSprint();
        }
        public void FinishSprint()
        {
            this.sprintState.FinishSprint();
        }
        public void CancelSprint()
        {
            this.sprintState.CancelSprint();
        }
        public void CompleteSprint()
        {
            this.sprintState.CompleteSprint();
        }

        internal void SetState(IPartialProductSprintState sprintState)
        {
            this.sprintState = sprintState;
        }
    }
}
