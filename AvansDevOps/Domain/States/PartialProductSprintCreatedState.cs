using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class PartialProductSprintCreatedState : IPartialProductSprintState
    {
        private readonly PartialProductSprint sprint;

        public PartialProductSprintCreatedState(PartialProductSprint sprint)
        {
            this.sprint = sprint;
        }

        void IPartialProductSprintState.CancelRelease()
        {
            throw new NotImplementedException();
        }

        void IPartialProductSprintState.CancelSprint()
        {
            throw new NotImplementedException();
        }

        void ISprintState.ChangeEndDate(DateTime endDate)
        {
            throw new NotImplementedException();
        }

        void ISprintState.ChangeName(string name)
        {
            this.sprint.name = name;
        }

        void ISprintState.ChangeStartDate(DateTime startDate)
        {
            throw new NotImplementedException();
        }

        void IPartialProductSprintState.FinishSprint()
        {
            throw new NotImplementedException();
        }

        void IPartialProductSprintState.Release()
        {
            throw new NotImplementedException();
        }

        void IPartialProductSprintState.StartSprint()
        {
            Console.WriteLine("Sprint started!");
            this.sprint.SetState(new PartialProductSprintInProgressState(this.sprint));
        }
    }
}
