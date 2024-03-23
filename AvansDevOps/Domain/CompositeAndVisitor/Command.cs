
using AvansDevOps.Domain.Pipeline;

namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class Command : Component
    {
        private readonly string command;

        public Command(string command)
        {
            this.command = command;
        }

        public string GetCommand()
        {
            return this.command;
        }

        internal override void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitCommand(this);
        }
    }
}
