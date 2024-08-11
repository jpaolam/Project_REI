using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDomain.Setup.Entities;
using ProjectInfrastructure.Common;
using ProjectInfrastructure.Data;
using ProjectDomain.Setup.Interfaces;

namespace ProjectInfrastructure.Setup.Repositories
{
    public class EntidadesRepository : IEntidadRepository
    {
        private readonly ProjectDbContext _context;

        public EntidadesRepository(ProjectDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Entidad>> GetAllAsync()
        {
            return await Task.Run(() => _context.entidades.ToList());
        }

        public async Task<Entidad> GetByIdAsync(int id)
        {
            return await Task.Run(() => _context.entidades.FirstOrDefault(x => x.Id == id));
        }

        public async Task AddAsync(ProjectDomain.Setup.Entities.Entidad entidad)
        {
            await _context.entidades.AddAsync(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ProjectDomain.Setup.Entities.Entidad entidad, int id)
        {
            _context.ChangeTracker.Clear();
            _context.entidades.Update(entidad);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entidad = await GetByIdAsync(id);
            _context.entidades.Remove(entidad);
            await _context.SaveChangesAsync();
        }
        //public async Task<bool> IsRazonSocialUniqueAsync(string razonSocial, int id)
        //{
        //    var empresaId = await empresaIdService.GetId();
        //    return !await _context.CentroCostos.AnyAsync(t =>
        //        t.Nombre == nombre && t.Id != id && t.EmpresaId == empresaId);
        //}

    }
}
