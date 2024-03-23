using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Domain.States.PartialProductSprintStates;

namespace AvansDevOps.Domain
{
    internal class PartialProductSprint : Sprint
    {
        private IPartialProductSprintState sprintState;
        public PartialProductSprint(Project project, string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, LinkedList<Tester> testers, LinkedList<BacklogItem> backlog) : base(project, name, startDate, endDate, scrumMaster, developers, testers, backlog)
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



        internal void SetState(IPartialProductSprintState sprintState)
        {
            this.sprintState = sprintState;
        }

        public override void Notify(Sprint sprint, ISprintState oldState)
        {
            throw new NotImplementedException();
        }
    }
}
