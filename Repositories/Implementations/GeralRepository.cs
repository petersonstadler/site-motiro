using site_motiro.Repositories.Interfaces;

namespace site_motiro.Repositories.Implementations
{
    public class GeralRepository : IGeralRepository
    {
        public IEnumerable<string> GetEditions()
        {
            var edicoesRealizadas = new List<string>()
            {
                "2022",
                "2023"
            };

            return edicoesRealizadas;
        }
    }
}
