namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class DryRunVisitor : Visitor
    {
        internal override void VisitPipeline(Pipeline pipeline)
        {
            throw new NotImplementedException();
        }

        internal override void VisitStage(Stage stage)
        {
            throw new NotImplementedException();
        }

        internal override void VisitCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
