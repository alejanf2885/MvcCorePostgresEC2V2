using Microsoft.EntityFrameworkCore;
using MvcCorePostgresEC2V2.Data;
using MvcCorePostgresEC2V2.Models;

namespace MvcCorePostgresEC2V2.Repository
{
    public class RepositoryDepartamentos
    {
        private HospitalContext context;

        public RepositoryDepartamentos(HospitalContext context)
        {
            this.context = context;
        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            return await this.context.Departamentos.ToListAsync();
        }

        public async Task<Departamento> FindDepartamentoAsync(int id)
        {
            return await this.context.Departamentos.FindAsync(id);
        }

        public async Task InsertDepartamentoAsync(int id, string nombre, string localidad)
        {
            Departamento dept = new Departamento
            {
                Id = id,
                Nombre = nombre,
                Localidad = localidad,
            };
            await this.context.Departamentos.AddAsync(dept);
            await this.context.SaveChangesAsync();
        }
    }
}
