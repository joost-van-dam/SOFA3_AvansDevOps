namespace AvansDevOps.Domain.States.Abstracts
{
    internal interface IBacklogItemActivityState
    {
        void SetDoingStatus();

        void SetDoneStatus();

        void SetTodoStatus();
    }
}
