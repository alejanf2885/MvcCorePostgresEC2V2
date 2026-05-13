using Microsoft.EntityFrameworkCore;
using MvcCorePostgresEC2V2.Models;

namespace MvcCorePostgresEC2V2.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
    }
}
