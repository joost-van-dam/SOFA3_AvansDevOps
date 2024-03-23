using AvansDevOps.Domain.States.Abstracts;

namespace AvansDevOps.Domain.ObserverPattern.SprintObserver
{
    internal interface ISprintObserver
    {
        void Update(Sprint sprint, ISprintState oldState);
    }
}