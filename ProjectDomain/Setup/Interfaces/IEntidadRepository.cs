using ProjectDomain.Setup.Entities;

namespace ProjectDomain.Setup.Interfaces
{
    public interface IEntidadRepository
    {
        //Formas de como se comunicara  a la base de datos
        Task<IEnumerable<Entidad?>> GetAllAsync();
        Task<Entidad?> GetByIdAsync(int id);
        Task AddAsync(Entidad entidad);
        Task UpdateAsync(Entidad entidad, int id);
        Task DeleteAsync(int id);
    }
}
