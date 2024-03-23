using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.ObserverPattern.SprintObserver
{
    internal interface IObservableSprint
    {
        void Subscribe(ISprintObserver observer);
        void Unsubscribe(ISprintObserver observer);
        void Notify(Sprint sprint, ISprintState oldState);
    }
}
