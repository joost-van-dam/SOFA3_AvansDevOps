using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.PartialProductSprintStates
{
    internal class PartialProductSprintCreatedState : IPartialProductSprintState
    {
        private readonly PartialProductSprint sprint;

        public PartialProductSprintCreatedState(PartialProductSprint sprint)
        {
            this.sprint = sprint;
        }

        void IPartialProductSprintState.CompleteSprint()
        {
            Console.WriteLine("The sprint has not been started & finished yet, so can not be completed!");
        }

        void IPartialProductSprintState.CancelSprint()
        {
            Console.WriteLine("Sprint canceled!");
            sprint.SetState(new PartialProductSprintCanceledState(sprint));
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

        void IPartialProductSprintState.FinishSprint()
        {
            Console.WriteLine("The sprint has not started yet, so can not be finished!");
        }



        void IPartialProductSprintState.StartSprint()
        {
            Console.WriteLine("Sprint started successfully!");
            sprint.SetState(new PartialProductSprintInProgressState(sprint));
        }
    }
}
