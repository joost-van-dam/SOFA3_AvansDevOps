using AvansDevOps.Domain.People;

namespace AvansDevOps.Infrastructure.Adapters
{
    internal interface INotifier
    {
        void SendNotification(Person person, string message);
    }
}
