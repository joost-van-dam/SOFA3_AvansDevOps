using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.BacklogItemStates
{
    internal class BacklogItemReadyForTestingState : IBacklogItemState
    {
        private readonly BacklogItem backlogItem;

        public BacklogItemReadyForTestingState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        bool IBacklogItemState.CreatesNotification()
        {
            return false;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            Console.WriteLine("Status can not be changed to doing, the tester first has to review the item!");
            //Console.WriteLine("Status successfully changed to doing");
            //this.backlogItem.SetState(new BacklogItemDoingState(this.backlogItem));
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
            backlogItem.SetState(new BacklogItemTestingState(backlogItem));
        }

        void IBacklogItemState.SetTodoStatus()
        {
            Console.WriteLine("Status can not be changed to to-do, the tester first has to review the item!");
            //Console.WriteLine("Status successfully changed to to-do");
            //this.backlogItem.SetState(new BacklogItemToDoState(this.backlogItem));
        }
    }
}
