using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.PartialProductSprintStates
{
    internal class PartialProductSprintCanceledState : IPartialProductSprintState
    {
        private readonly PartialProductSprint sprint;

        public PartialProductSprintCanceledState(PartialProductSprint sprint)
        {
            this.sprint = sprint;
        }

        void IPartialProductSprintState.CompleteSprint()
        {
            Console.WriteLine("The sprint has already been canceled, so can not be completed anymore!");
        }

        void IPartialProductSprintState.CancelSprint()
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

        void IPartialProductSprintState.FinishSprint()
        {
            Console.WriteLine("The sprint has already been canceled and can not be finished!");
        }

        void IPartialProductSprintState.StartSprint()
        {
            Console.WriteLine("The sprint has already been canceled and can not be started!");
        }
    }
}
