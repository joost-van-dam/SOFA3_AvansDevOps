using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.ObserverPattern
{
    internal interface IBacklogItemObserver
    {
        public void Update(BacklogItem backlogItem, IBacklogItemState newState);
    }
}
