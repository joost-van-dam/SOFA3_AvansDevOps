namespace AvansDevOps.Domain.States.Abstracts
{
    internal interface IBacklogItemState
    {
        void SetDoingStatus();

        void SetReadyForTestingStatus();

        void SetTestingStatus();

        void SetTestedStatus();

        void SetDoneStatus();

        void SetTodoStatus();

        bool CreatesNotification();
    }
}
