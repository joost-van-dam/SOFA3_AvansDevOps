using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.ReleaseSprintStates
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
            Console.WriteLine("The sprint has already been canceled, so there won't be any release!");
        }

        void IReleaseSprintState.CancelSprint()
        {
            Console.WriteLine("The sprint has already been canceled!");
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
            Console.WriteLine("The sprint has already been canceled and can not be finished!");
        }

        void IReleaseSprintState.Release()
        {
            Console.WriteLine("The sprint has already been canceled and can not be released!");
        }

        void IReleaseSprintState.StartSprint()
        {
            Console.WriteLine("The sprint has already been canceled and can not be started!");
        }
    }
}
