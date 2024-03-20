namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal interface Visitor
    {
        void VisitPipeline(Pipeline pipeline);

        void VisitStage(Stage stage);

        void VisitCommand(Command command);

    }
}
