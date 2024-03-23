namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class Pipeline : CompositeComponent
    {
        private readonly string name;

        public Pipeline(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        internal override void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitPipeline(this);
            base.AcceptVisitor(visitor);
        }
    }
}
