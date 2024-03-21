using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States
{
    internal class BacklogItemTestingState : IBacklogItemState
    {
        private readonly BackLogItem backLogItem;

        public BacklogItemTestingState(BackLogItem backLogItem)
        {
            this.backLogItem = backLogItem;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            Console.WriteLine("The status can only be set to tested or to-do if the item has issuess");
        }

        void IBacklogItemState.SetDoneStatus()
        {
            Console.WriteLine("Backlog item first has to be tested");
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            Console.WriteLine("Status successfully changed to ready-for-testing");
            this.backLogItem.SetState(new BacklogItemReadyForTestingState(this.backLogItem));
        }

        void IBacklogItemState.SetTestedStatus()
        {
            Console.WriteLine("Status successfully changed to tested");
            this.backLogItem.SetState(new BacklogItemTestedState(this.backLogItem));
        }

        void IBacklogItemState.SetTestingStatus()
        {
            Console.WriteLine("Status is already testing");
        }

        void IBacklogItemState.SetTodoStatus()
        {
            //berichtje naar scrummaster en product owner dat item afgekeurd is
            Console.WriteLine("Status successfully changed to to-do");
            //this.backLogItem.Notify(new Notification(TypeOfReceiver.ScrumMasterAndProductOwner, $"{backLogItem.GetName} van {backLogItem.GetDeveloperFullName} is afgekeurd door de tester en terug naar to-do verplaatst."));
            this.backLogItem.SetState(new BacklogItemToDoState(this.backLogItem));
        }
    }
}
