using site_motiro.Models;

namespace site_motiro.Repositories.Interfaces
{
    public interface IColaboradoresRepository
    {
        IEnumerable<Colaborador> GetAllColaboradores();
    }
}
