using AvansDevOps.Domain.Strategy.Abstracts;

namespace AvansDevOps.Domain.Strategy
{
    internal class SprintPDFRapportExportStrategy : ISprintRapportExportStrategy
    {
        private readonly Sprint sprint;

        public SprintPDFRapportExportStrategy(Sprint sprint)
        {
            this.sprint = sprint;
        }

        void ISprintRapportExportStrategy.ExportSprintRapport()
        {
            // hier in logica voor exporteren van sprint rapport in de vorm van een PDF (het in het juiste formaat zetten van de data)
            Console.WriteLine("Exporting sprint report as PDF");
        }
    }
}
