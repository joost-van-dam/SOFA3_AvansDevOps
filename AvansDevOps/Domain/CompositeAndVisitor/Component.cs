using AvansDevOps.Domain.CompositeAndVisitor;

namespace AvansDevOps.Domain.Pipeline
{
    internal abstract class Component
    {
        internal abstract void AcceptVisitor(Visitor visitor);
    }
}
