using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class PartialProductSprintFinishedState : IPartialProductSprintState
    {
        private readonly PartialProductSprint sprint;

        public PartialProductSprintFinishedState(PartialProductSprint sprint)
        {
            this.sprint = sprint;
        }

        void IPartialProductSprintState.CompleteSprint()
        {
            // HIER MOET DAT UPLOAD DOCUMENT VOOR DE SCRUMMASTER KOMEN!!!
            // IETS VAN EEN CHECK

            this.sprint.SetState(new PartialProductSprintCompletedState(this.sprint));
        }

        void IPartialProductSprintState.CancelSprint()
        {
            Console.WriteLine("The sprint has already been finished, so can not be canceled anymore.");
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
            Console.WriteLine("The sprint has already been finished.");
        }


        void IPartialProductSprintState.StartSprint()
        {
            Console.WriteLine("The sprint has already been finished and can not be started!");
        }
    }
}
