using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class ReleaseSprintFinishedState : IReleaseSprintState
    {
        private readonly ReleaseSprint sprint;
        public ReleaseSprintFinishedState(ReleaseSprint sprint)
        {
            this.sprint = sprint;
        }

        void IReleaseSprintState.CancelRelease()
        {
            // hier goedkeuring van product owner of scrum master toevoegen!

            this.sprint.SetState(new ReleaseSprintReleaseCanceledState(this.sprint));
        }

        void IReleaseSprintState.CancelSprint()
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

        void IReleaseSprintState.FinishSprint()
        {
            Console.WriteLine("The sprint has already been finished!");
        }

        void IReleaseSprintState.Release()
        {
            // hier goedkeuring van product owner of scrum master toevoegen!

            // hier ook de pipeline aftrappen en checken of hij het doet anders foutmelding geven


            this.sprint.SetState(new ReleaseSprintReleaseCompletedState(this.sprint));
        }

        void IReleaseSprintState.StartSprint()
        {
            Console.WriteLine("The sprint has already been finished, so can not be started!");
        }
    }
}
