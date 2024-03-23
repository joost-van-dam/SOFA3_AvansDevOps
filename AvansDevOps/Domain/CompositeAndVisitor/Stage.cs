namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class Stage : CompositeComponent
    {
        private readonly string name;

        public Stage(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        internal override void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitStage(this);
            base.AcceptVisitor(visitor);
        }
    }
}
