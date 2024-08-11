using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectApplication.Setup.Dto;
using ProjectDomain.Setup.Entities;

namespace ProjectApplication.Setup.Interfaces
{
    public interface IEntidadService
    {
        Task<IEnumerable<Entidad?>> GetAllAsync();
        Task<EntidadDto?> GetByIdAsync(int id);

        //Task<Entidad?> GetByDocumentAsync(string documento);
        Task<Result> AddAsync(EntidadDto entidadDto);
        Task<Result> UpdateAsync(EntidadDto entidadDto, int id);
        Task DeleteAsync(int id);
    }
}
