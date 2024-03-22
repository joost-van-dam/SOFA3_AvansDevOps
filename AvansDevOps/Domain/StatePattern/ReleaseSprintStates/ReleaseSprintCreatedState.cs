using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.ReleaseSprintStates
{
    internal class ReleaseSprintCreatedState : IReleaseSprintState
    {
        private readonly ReleaseSprint sprint;

        public ReleaseSprintCreatedState(ReleaseSprint sprint)
        {
            this.sprint = sprint;
        }

        void IReleaseSprintState.CancelRelease()
        {
            Console.WriteLine("The sprint has not started & finished yet, so the release can not be executed or canceled!");
        }

        void IReleaseSprintState.CancelSprint()
        {
            Console.WriteLine("Sprint canceled!");
            sprint.SetState(new ReleaseSprintCanceledState(sprint));
        }

        void ISprintState.ChangeEndDate(DateTime endDate)
        {
            Console.WriteLine($"EndDate of the sprint succesfully changed to {endDate.ToString()}");
            sprint.endDate = endDate;
        }

        void ISprintState.ChangeName(string name)
        {
            Console.WriteLine($"Sprint name successfully changed to {name}");
            sprint.name = name;
        }

        void ISprintState.ChangeStartDate(DateTime startDate)
        {
            Console.WriteLine($"StartDate of the sprint succesfully changed to {startDate.ToString()}");
            sprint.startDate = startDate;
        }

        void IReleaseSprintState.FinishSprint()
        {
            Console.WriteLine("The sprint has not started yet, so can not be finished!");
        }

        void IReleaseSprintState.Release()
        {
            Console.WriteLine("The sprint has not started & finished yet, so can not be released!");
        }

        void IReleaseSprintState.StartSprint()
        {
            Console.WriteLine("Sprint started successfully!");
            sprint.SetState(new ReleaseSprintInProgressState(sprint));
        }
    }
}
