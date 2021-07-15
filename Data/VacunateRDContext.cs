using Microsoft.EntityFrameworkCore;
using Vacunate_RD.Data;
namespace Vacunate_RD
{
    class VacunateRDContext  : DbContext
    {
        public DbSet<Vacunado> Vacunados { get; set; }
        public DbSet<Vacuna> Vacunas { get; set; }
        public DbSet<Provincia> Provincias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opcionA)
        {
            if (!opcionA.IsConfigured)
            {
                opcionA.UseSqlite("Data Source=VacunateRD.db");
            }
        }
    }
}