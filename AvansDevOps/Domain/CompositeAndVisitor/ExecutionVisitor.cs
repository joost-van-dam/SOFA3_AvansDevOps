namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class ExecutionVisitor : Visitor
    {
        void Visitor.VisitPipeline(Pipeline pipeline)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"Execution of: {pipeline.GetName()}");
            Console.WriteLine("===================================");
        }

        void Visitor.VisitStage(Stage stage)
        {
            Console.WriteLine();
            Console.WriteLine($"Stage: {stage.GetName()}");
        }

        void Visitor.VisitCommand(Command command)
        {
            Console.WriteLine($"Executed Command: {command.GetCommand()}");
        }
    }
}
