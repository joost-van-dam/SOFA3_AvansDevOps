using AvansDevOps.Domain.People;

namespace AvansDevOps.Infrastructure.Adapters
{
    internal interface INotifier
    {
        void Notify(Person person, string message);
    }
}
