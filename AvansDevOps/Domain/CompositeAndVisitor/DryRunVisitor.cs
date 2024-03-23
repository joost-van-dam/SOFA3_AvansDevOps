namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class DryRunVisitor : IVisitor
    {
        void IVisitor.VisitPipeline(Pipeline pipeline)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"Dry run of: {pipeline.GetName()}");
            Console.WriteLine("===================================");
        }

        void IVisitor.VisitStage(Stage stage)
        {
            Console.WriteLine();
            Console.WriteLine($"Stage: {stage.GetName()}");
        }

        void IVisitor.VisitCommand(Command command)
        {
            Console.WriteLine($"Command: {command.GetCommand()}");
        }
    }
}
