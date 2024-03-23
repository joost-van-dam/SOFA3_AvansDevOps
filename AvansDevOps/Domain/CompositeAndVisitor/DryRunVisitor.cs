namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class DryRunVisitor : IVisitor
    {
        void IVisitor.VisitPipeline(Pipeline pipeline)
        {
            Console.WriteLine($"===================================\nDry run of: {pipeline.GetName()}\n===================================");
        }

        void IVisitor.VisitStage(Stage stage)
        {
            Console.WriteLine($"\nStage: {stage.GetName()}");
        }

        void IVisitor.VisitCommand(Command command)
        {
            Console.WriteLine($"Command: {command.GetCommand()}");
        }
    }
}
