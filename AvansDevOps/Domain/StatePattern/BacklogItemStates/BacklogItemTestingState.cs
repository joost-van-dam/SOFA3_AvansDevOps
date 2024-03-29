﻿using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.BacklogItemStates
{
    internal class BacklogItemTestingState : IBacklogItemState
    {
        private readonly BacklogItem backlogItem;

        public BacklogItemTestingState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
        }

        // leg het in de state vast
        //methode bij maken 
        //in interface
        bool IBacklogItemState.CreatesNotification()
        {
            return false;
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
            backlogItem.SetState(new BacklogItemReadyForTestingState(backlogItem));
        }

        void IBacklogItemState.SetTestedStatus()
        {
            Console.WriteLine("Status successfully changed to tested");
            backlogItem.SetState(new BacklogItemTestedState(backlogItem));
        }

        void IBacklogItemState.SetTestingStatus()
        {
            Console.WriteLine("Status is already testing");
        }

        void IBacklogItemState.SetTodoStatus()
        {
            //berichtje naar scrummaster en product owner dat item afgekeurd is
            Console.WriteLine("Status successfully changed to to-do");
            backlogItem.SetState(new BacklogItemTestingRejectedState(backlogItem));
        }

    }
}
