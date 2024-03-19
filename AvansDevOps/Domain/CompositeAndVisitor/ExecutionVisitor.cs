namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class ExecutionVisitor : Visitor
    {
        internal override void VisitPipeline(Pipeline pipeline)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"Pipeline name: {pipeline.GetName()}");
            Console.WriteLine("===================================");
        }

        internal override void VisitStage(Stage stage)
        {
            Console.WriteLine();
            Console.WriteLine($"Stage: {stage.GetName()}");
        }

        internal override void VisitCommand(Command command)
        {
            Console.WriteLine($"Command: {command.GetCommand()}");
        }
    }
}
