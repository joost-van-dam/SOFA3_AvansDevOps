namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal abstract class Visitor
    {
        internal abstract void VisitPipeline(Pipeline pipeline);

        internal abstract void VisitStage(Stage stage);

        internal abstract void VisitCommand(Command command);

    }
}
