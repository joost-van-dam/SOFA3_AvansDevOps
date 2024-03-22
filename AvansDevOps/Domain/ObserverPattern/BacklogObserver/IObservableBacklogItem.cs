using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.ObserverPattern.BacklogObserver
{
    internal interface IObservableBacklogItem
    {
        void Subscribe(IBacklogItemObserver observer);
        void Unsubscribe(IBacklogItemObserver observer);
        void Notify(BacklogItem backlogItem, IBacklogItemState newState);
    }
}
