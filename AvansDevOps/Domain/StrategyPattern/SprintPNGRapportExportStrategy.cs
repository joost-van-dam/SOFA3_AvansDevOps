using AvansDevOps.Domain.Strategy.Abstracts;

namespace AvansDevOps.Domain.Strategy
{
    internal class SprintPNGRapportExportStrategy : ISprintRapportExportStrategy
    {
        void ISprintRapportExportStrategy.ExportSprintRapport(Sprint spring)
        {
            // hier in logica voor exporteren van sprint rapport in de vorm van een PNG (het in het juiste formaat zetten van de data)
            throw new NotImplementedException();
        }
    }
}
