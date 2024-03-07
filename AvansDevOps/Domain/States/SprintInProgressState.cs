using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class SprintInProgressState : ISprintState
    {
        private readonly Sprint sprint;

        public SprintInProgressState(Sprint sprint)
        {
            this.sprint = sprint;
        }

        void ISprintState.ChangeEndDate(DateTime endDate)
        {
            Console.WriteLine("The enddate can only be changed when the sprints state is in 'Created'");
        }

        void ISprintState.ChangeName(string name)
        {
            Console.WriteLine("The name can only be changed when the sprints state is in 'Created'");
        }

        void ISprintState.ChangeStartDate(DateTime startDate)
        {
            Console.WriteLine("The startdate can only be changed when the sprints state is in 'Created'");
        }
    }
}
