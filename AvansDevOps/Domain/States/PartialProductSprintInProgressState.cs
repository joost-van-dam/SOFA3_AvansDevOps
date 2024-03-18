using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
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
            Console.WriteLine("Sprint finished successfully!");
            this.sprint.SetState(new PartialProductSprintFinishedState(this.sprint));
        }


        void IPartialProductSprintState.StartSprint()
        {
            Console.WriteLine("The sprint has already been started!");
        }
    }
}
