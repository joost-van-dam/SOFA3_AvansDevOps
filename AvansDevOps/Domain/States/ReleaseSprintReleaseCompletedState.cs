using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class ReleaseSprintReleaseCompletedState : IReleaseSprintState
    {
        private readonly ReleaseSprint sprint;

        public ReleaseSprintReleaseCompletedState(ReleaseSprint sprint)
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
            Console.WriteLine("The EndDate can only be changed when the sprint has not started!");
        }

        void ISprintState.ChangeName(string name)
        {
            Console.WriteLine("The sprint name can only be changed when the sprint has not started!");
        }

        void ISprintState.ChangeStartDate(DateTime startDate)
        {
            Console.WriteLine("The StartDate can only be changed when the sprint has not started!");
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
