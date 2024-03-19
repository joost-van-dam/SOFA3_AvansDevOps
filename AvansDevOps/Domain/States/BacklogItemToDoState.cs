using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemToDoState : IBacklogItemState
    {
        private readonly BackLogItem backLogItem;

        public BacklogItemToDoState(BackLogItem backLogItem)
        {
            this.backLogItem = backLogItem;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            Console.WriteLine("Status successfully changed to doing");
            this.backLogItem.SetState(new BacklogItemDoingState(this.backLogItem));
        }

        void IBacklogItemState.SetDoneStatus()
        {
            Console.WriteLine("Status first has to be doing");
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            Console.WriteLine("Status first has to be doing");
        }

        void IBacklogItemState.SetTestedStatus()
        {
            Console.WriteLine("Status first has to be doing");
        }

        void IBacklogItemState.SetTestingStatus()
        {
            Console.WriteLine("Status first has to be doing");
        }

        void IBacklogItemState.SetTodoStatus()
        {
            Console.WriteLine("Status is already to-do");
        }
    }
}
