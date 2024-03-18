using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class ReleaseSprintCanceledState : IReleaseSprintState
    {
        private readonly ReleaseSprint sprint;

        public ReleaseSprintCanceledState(ReleaseSprint sprint)
        {
            this.sprint = sprint;
        }

        void IReleaseSprintState.CancelRelease()
        {
            throw new NotImplementedException();
        }

        void IReleaseSprintState.CancelSprint()
        {
            throw new NotImplementedException();
        }

        void ISprintState.ChangeEndDate(DateTime endDate)
        {
            throw new NotImplementedException();
        }

        void ISprintState.ChangeName(string name)
        {
            throw new NotImplementedException();
        }

        void ISprintState.ChangeStartDate(DateTime startDate)
        {
            throw new NotImplementedException();
        }

        void IReleaseSprintState.FinishSprint()
        {
            throw new NotImplementedException();
        }

        void IReleaseSprintState.Release()
        {
            throw new NotImplementedException();
        }

        void IReleaseSprintState.StartSprint()
        {
            throw new NotImplementedException();
        }
    }
}
