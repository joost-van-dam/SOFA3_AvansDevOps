namespace AvansDevOps.Domain.CompositeAndVisitor
{
    internal class ExecutionVisitor : Visitor
    {
        internal override void VisitPipeline(Pipeline pipeline)
        {
            Console.WriteLine("===================================");
            Console.WriteLine($"{pipeline.GetName()}");
            Console.WriteLine("===================================");
        }

        internal override void VisitStage(Stage stage)
        {
            Console.WriteLine("---------------");
            Console.WriteLine($"{stage.GetName()}");
            Console.WriteLine("---------------");
        }

        internal override void VisitCommand(Command command)
        {
            Console.WriteLine("****************");
            Console.WriteLine($"{command.GetCommand()}");
            Console.WriteLine("****************");
        }
    }
}
