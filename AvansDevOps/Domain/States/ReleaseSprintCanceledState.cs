using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class ReleaseSprintCanceledState : IReleaseSprintState
    {
        private readonly Sprint sprint;

        public ReleaseSprintCanceledState(Sprint sprint)
        {
            this.sprint = sprint;
        }

        void IReleaseSprintState.ChangeEndDate(DateTime endDate)
        {
            Console.WriteLine("The enddate can only be changed when the sprints state is in 'Created'");
        }

        void IReleaseSprintState.ChangeName(string name)
        {
            Console.WriteLine("The name can only be changed when the sprints state is in 'Created'");
        }

        void IReleaseSprintState.ChangeStartDate(DateTime startDate)
        {
            Console.WriteLine("The startdate can only be changed when the sprints state is in 'Created'");
        }
    }
}
