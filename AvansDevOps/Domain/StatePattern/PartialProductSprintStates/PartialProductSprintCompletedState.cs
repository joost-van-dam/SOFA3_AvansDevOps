using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.PartialProductSprintStates
{
    internal class PartialProductSprintCompletedState : IPartialProductSprintState
    {
        private readonly PartialProductSprint sprint;

        public PartialProductSprintCompletedState(PartialProductSprint sprint)
        {
            this.sprint = sprint;
        }

        void IPartialProductSprintState.CompleteSprint()
        {
            Console.WriteLine("The sprint has already been completed!");
        }

        void IPartialProductSprintState.CancelSprint()
        {
            Console.WriteLine("The sprint is already completed and can not be canceled anymore!");
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
            Console.WriteLine("The sprint has already been completed, so can not be finished again!");
        }


        void IPartialProductSprintState.StartSprint()
        {
            Console.WriteLine("The sprint has already been completed and can not be started!");
        }
    }
}
