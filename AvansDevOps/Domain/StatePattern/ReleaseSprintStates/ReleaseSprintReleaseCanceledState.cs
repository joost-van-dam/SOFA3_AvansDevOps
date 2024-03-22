using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.ReleaseSprintStates
{
    internal class ReleaseSprintReleaseCanceledState : IReleaseSprintState
    {
        private readonly ReleaseSprint sprint;

        public ReleaseSprintReleaseCanceledState(ReleaseSprint sprint)
        {
            this.sprint = sprint;
        }

        void IReleaseSprintState.CancelRelease()
        {
            Console.WriteLine("The release has already been canceled!");
        }

        void IReleaseSprintState.CancelSprint()
        {
            Console.WriteLine("The sprint has already been completed, so can not be canceled anymore!");
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
            Console.WriteLine("The sprint has already been completed, so can not be finished anymore!");
        }

        void IReleaseSprintState.Release()
        {
            Console.WriteLine("The release has already been completed!");
        }

        void IReleaseSprintState.StartSprint()
        {
            Console.WriteLine("The sprint has already been completed, so can not be started anymore!");
        }
    }
}
