using AvansDevOps.Domain.Pipeline;

namespace AvansDevOps.Domain.CompositeAndVisitor
{
    //waarom deze niet abstract, want het lijkt me dat niet geen compositecomponent object wilt maken
    internal abstract class CompositeComponent : Component
    {
        private readonly List<Component> parts = new List<Component>();

        public void AddComponent(Component comp)
        {
            parts.Add(comp);
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
