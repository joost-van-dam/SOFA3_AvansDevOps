using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.ObserverPattern.BacklogObserver
{
    internal interface IBacklogItemObserver
    {
        internal void Update(BacklogItem backlogItem, IBacklogItemState oldState);
    }
}
