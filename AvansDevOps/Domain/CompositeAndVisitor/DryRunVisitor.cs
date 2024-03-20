namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class DryRunVisitor : Visitor
    {
        void Visitor.VisitPipeline(Pipeline pipeline)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"Dry run of: {pipeline.GetName()}");
            Console.WriteLine("===================================");
        }

        void Visitor.VisitStage(Stage stage)
        {
            Console.WriteLine();
            Console.WriteLine($"Stage: {stage.GetName()}");
        }

        void Visitor.VisitCommand(Command command)
        {
            Console.WriteLine($"Command: {command.GetCommand()}");
        }
    }
}
