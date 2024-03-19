namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class Stage : CompositeComponent
    {
        private string name;

        public Stage(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        internal override void AcceptVisitor(Visitor visitor)
        {
            //Console.WriteLine("wordt deze wel uitgevoerd??");
            //Console.WriteLine($"{name} dit is de naam test");
            visitor.VisitStage(this);
            base.AcceptVisitor(visitor);
        }
    }
}
