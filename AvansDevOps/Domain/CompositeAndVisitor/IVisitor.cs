namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal interface IVisitor
    {
        void VisitPipeline(Pipeline pipeline);

        void VisitStage(Stage stage);

        void VisitCommand(Command command);

    }
}
