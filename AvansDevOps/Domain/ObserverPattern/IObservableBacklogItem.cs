using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.ObserverPattern
{
    internal interface IObservableBacklogItem
    {
        void Attach(IBacklogItemObserver observer);
        void Detach(IBacklogItemObserver observer);
        void Notify(BacklogItem backlogItem, IBacklogItemState newState);
    }
}
