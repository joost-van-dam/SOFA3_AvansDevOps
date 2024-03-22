using AvansDevOps.Domain.People;
using AvansDevOps.Domain.States.Abstracts;
using AvansDevOps.Domain.States.ReleaseSprintStates;

namespace AvansDevOps.Domain
{
    internal class ReleaseSprint : Sprint
    {
        private IReleaseSprintState sprintState;
        public ReleaseSprint(Project project, string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, LinkedList<Developer> developers, LinkedList<Tester> testers, LinkedList<BacklogItem> backlog) : base(project, name, startDate, endDate, scrumMaster, developers, testers, backlog/*, sprintState*/)
        {
            this.sprintState = new ReleaseSprintCreatedState(this);
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

        public void Release()
        {
            this.sprintState.Release();
        }

        public void CancelRelease()
        {
            this.sprintState.CancelRelease();
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


        internal void SetState(IReleaseSprintState sprintState)
        {
            this.sprintState = sprintState;
        }

        public override void Notify(Sprint sprint, ISprintState newState)
        {
            throw new NotImplementedException();
        }
    }
}
