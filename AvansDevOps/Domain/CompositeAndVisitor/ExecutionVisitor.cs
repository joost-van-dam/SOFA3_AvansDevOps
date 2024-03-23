namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class ExecutionVisitor : IVisitor
    {
        void IVisitor.VisitPipeline(Pipeline pipeline)
        {
            Console.WriteLine($"===================================\nExecution of: {pipeline.GetName()}\n===================================");
        }

        void IVisitor.VisitStage(Stage stage)
        {
            Console.WriteLine($"\nStage: {stage.GetName()}");
        }

        void IVisitor.VisitCommand(Command command)
        {
            Console.WriteLine($"Executed Command: {command.GetCommand()}");
        }
    }
}
