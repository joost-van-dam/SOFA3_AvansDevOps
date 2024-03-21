using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemDoingState : IBacklogItemState
    {
        private readonly BackLogItem backLogItem;

        public BacklogItemDoingState(BackLogItem backLogItem)
        {
            this.backLogItem = backLogItem;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            Console.WriteLine("Status is already doing");
        }

        void IBacklogItemState.SetDoneStatus()
        {
            Console.WriteLine("Status first has to be ready-for-testing");
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            Console.WriteLine("Status successfully changed to ready-for-testing");
            //verzend de testers een notificatie
            this.backLogItem.Notify();

            this.backLogItem.SetState(new BacklogItemReadyForTestingState(this.backLogItem));
        }

        void IBacklogItemState.SetTestedStatus()
        {
            Console.WriteLine("Status first has to be ready-for-testing");
        }

        void IBacklogItemState.SetTestingStatus()
        {
            Console.WriteLine("Status first has to be ready-for-testing");
        }

        void IBacklogItemState.SetTodoStatus()
        {
            Console.WriteLine("Status successfully changed to to-do");
            this.backLogItem.SetState(new BacklogItemToDoState(this.backLogItem));
        }
    }
}
