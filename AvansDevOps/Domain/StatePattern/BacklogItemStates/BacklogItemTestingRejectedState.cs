﻿using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.States.BacklogItemStates
{
    internal class BacklogItemTestingRejectedState : IBacklogItemState
    {
        private readonly BacklogItem backlogItem;

        public BacklogItemTestingRejectedState(BacklogItem backlogItem)
        {
            this.backlogItem = backlogItem;
            backlogItem.SetState(new BacklogItemToDoState(this.backlogItem));
        }

        bool IBacklogItemState.CreatesNotification()
        {
            return true;
        }

        void IBacklogItemState.SetDoingStatus()
        {
            throw new NotImplementedException();
        }

        void IBacklogItemState.SetDoneStatus()
        {
            throw new NotImplementedException();
        }

        void IBacklogItemState.SetReadyForTestingStatus()
        {
            throw new NotImplementedException();
        }

        void IBacklogItemState.SetTestedStatus()
        {
            throw new NotImplementedException();
        }

        void IBacklogItemState.SetTestingStatus()
        {
            throw new NotImplementedException();
        }

        void IBacklogItemState.SetTodoStatus()
        {
            throw new NotImplementedException();
        }
    }
}
