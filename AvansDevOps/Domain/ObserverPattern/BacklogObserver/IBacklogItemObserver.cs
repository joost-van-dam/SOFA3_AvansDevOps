using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.ObserverPattern.BacklogObserver
{
    internal interface IBacklogItemObserver
    {
        public void Update(BacklogItem backlogItem, IBacklogItemState newState);
    }
}
