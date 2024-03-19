using AvansDevOps.Domain.Pipeline;

namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class CompositeComponent : Component
    {
        private List<Component> parts;

        public CompositeComponent()
        {
            parts = new List<Component>();
        }

        public void AddComponent(Component comp)
        {
            parts.Add(comp);
        }

        public Component GetComponent(int i)
        {
            return parts[i];
        }

        public int GetSize()
        {
            return parts.Count;
        }

        internal override void AcceptVisitor(Visitor visitor)
        {
            foreach (Component component in this.parts)
            {
                component.AcceptVisitor(visitor);
            }
        }

    }
}
