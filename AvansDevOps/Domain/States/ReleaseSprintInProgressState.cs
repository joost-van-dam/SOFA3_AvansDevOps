using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class ReleaseSprintInProgressState : IReleaseSprintState
    {
        private readonly ReleaseSprint sprint;

        public ReleaseSprintInProgressState(ReleaseSprint sprint)
        {
            this.sprint = sprint;
        }

        void IReleaseSprintState.CancelRelease()
        {
            Console.WriteLine("The sprint has not finished yet, so the release can not be canceled yet!");
        }

        void IReleaseSprintState.CancelSprint()
        {
            Console.WriteLine("The sprint has already been started, so can not be canceled anymore.");
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
            Console.WriteLine("Sprint finished successfully!");
            this.sprint.SetState(new ReleaseSprintFinishedState(this.sprint));
        }

        void IReleaseSprintState.Release()
        {
            Console.WriteLine("The sprint has not finished yet, so can not be released!");
        }

        void IReleaseSprintState.StartSprint()
        {
            Console.WriteLine("The sprint has already been started!");
        }
    }
}
