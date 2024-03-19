using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemDoneState : IBacklogItemState
    {
        private readonly BackLogItem backLogItem;

        public BacklogItemDoneState(BackLogItem backLogItem)
        {
            this.backLogItem = backLogItem;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            Console.WriteLine("The backlog item's status is already set to done and can not be changed anymore!");
        }

        void IBacklogItemState.SetDoneStatus()
        {
            Console.WriteLine("The backlog item's status is already set to done!");
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            Console.WriteLine("The backlog item's status is already set to done and can not be changed anymore!");
        }

        void IBacklogItemState.SetTestedStatus()
        {
            Console.WriteLine("The backlog item's status is already set to done and can not be changed anymore!");
        }

        void IBacklogItemState.SetTestingStatus()
        {
            Console.WriteLine("The backlog item's status is already set to done and can not be changed anymore!");
        }

        void IBacklogItemState.SetTodoStatus()
        {
            Console.WriteLine("The backlog item's status is already set to done and can not be changed anymore!");
        }
    }
}
