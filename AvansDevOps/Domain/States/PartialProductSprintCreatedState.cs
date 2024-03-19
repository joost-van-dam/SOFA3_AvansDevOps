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

        void IPartialProductSprintState.CompleteSprint()
        {
            Console.WriteLine("The sprint has not been started & finished yet, so can not be completed!");
        }

        void IPartialProductSprintState.CancelSprint()
        {
            Console.WriteLine("Sprint canceled!");
            this.sprint.SetState(new PartialProductSprintCanceledState(this.sprint));
        }

        void ISprintState.ChangeEndDate(DateTime endDate)
        {
            Console.WriteLine($"EndDate of the sprint succesfully changed to {endDate.ToString()}");
            this.sprint.endDate = endDate;
        }

        void ISprintState.ChangeName(string name)
        {
            Console.WriteLine($"Sprint name successfully changed to {name}");
            this.sprint.name = name;
        }

        void ISprintState.ChangeStartDate(DateTime startDate)
        {
            Console.WriteLine($"StartDate of the sprint succesfully changed to {startDate.ToString()}");
            this.sprint.startDate = startDate;
        }

        void IPartialProductSprintState.FinishSprint()
        {
            Console.WriteLine("The sprint has not started yet, so can not be finished!");
        }



        void IPartialProductSprintState.StartSprint()
        {
            Console.WriteLine("Sprint started successfully!");
            this.sprint.SetState(new PartialProductSprintInProgressState(this.sprint));
        }
    }
}
