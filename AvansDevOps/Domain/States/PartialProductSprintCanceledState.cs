using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
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
            Console.WriteLine("The sprint has already been canceled, so can not be completed anymoer!");
        }

        void IPartialProductSprintState.CancelSprint()
        {
            Console.WriteLine("The sprint has already been canceled!");
        }

        void ISprintState.ChangeEndDate(DateTime endDate)
        {
            throw new NotImplementedException();
        }

        void ISprintState.ChangeName(string name)
        {
            throw new NotImplementedException();
        }

        void ISprintState.ChangeStartDate(DateTime startDate)
        {
            throw new NotImplementedException();
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
