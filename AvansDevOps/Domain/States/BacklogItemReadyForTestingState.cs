using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemReadyForTestingState : IBacklogItemState
    {
        private readonly BackLogItem backLogItem;

        public BacklogItemReadyForTestingState(BackLogItem backLogItem)
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
            Console.WriteLine("Backlog item first has to be tested");
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            Console.WriteLine("Status is already ready-for-testing");
        }

        void IBacklogItemState.SetTestedStatus()
        {
            Console.WriteLine("Status first has to be testing before it can be set to tested");
        }

        void IBacklogItemState.SetTestingStatus()
        {
            // gaan we hier nog iets in bouwen met een tester i.p.v. een developer?
            Console.WriteLine("Status successfully changed to testing");
            this.backLogItem.SetState(new BacklogItemTestingState(this.backLogItem));
        }

        void IBacklogItemState.SetTodoStatus()
        {
            Console.WriteLine("Status successfully changed to to-do");
            this.backLogItem.SetState(new BacklogItemToDoState(this.backLogItem));
        }
    }
}
