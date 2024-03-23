namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class ExecutionVisitor : IVisitor
    {
        void IVisitor.VisitPipeline(Pipeline pipeline)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"Execution of: {pipeline.GetName()}");
            Console.WriteLine("===================================");
        }

        void IVisitor.VisitStage(Stage stage)
        {
            Console.WriteLine();
            Console.WriteLine($"Stage: {stage.GetName()}");
        }

        void IVisitor.VisitCommand(Command command)
        {
            Console.WriteLine($"Executed Command: {command.GetCommand()}");
        }
    }
}
