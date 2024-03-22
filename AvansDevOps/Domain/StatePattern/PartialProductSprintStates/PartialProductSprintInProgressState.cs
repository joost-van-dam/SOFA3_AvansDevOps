using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.PartialProductSprintStates
{
    internal class PartialProductSprintInProgressState : IPartialProductSprintState
    {
        private readonly PartialProductSprint sprint;

        public PartialProductSprintInProgressState(PartialProductSprint sprint)
        {
            this.sprint = sprint;
        }

        void IPartialProductSprintState.CompleteSprint()
        {
            Console.WriteLine("The sprint has not been finished yet, so can not be completed!");
        }

        void IPartialProductSprintState.CancelSprint()
        {
            Console.WriteLine("The sprint has already been started, so can not be canceled anymore!");
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

        void IPartialProductSprintState.FinishSprint()
        {
            Console.WriteLine("Sprint finished successfully!");
            sprint.SetState(new PartialProductSprintFinishedState(sprint));
        }


        void IPartialProductSprintState.StartSprint()
        {
            Console.WriteLine("The sprint has already been started!");
        }
    }
}
