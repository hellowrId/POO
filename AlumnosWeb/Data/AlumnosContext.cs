using AlumnosWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AlumnosWeb.Data
{
    public class AlumnosContext : DbContext
    {
        public AlumnosContext(DbContextOptions<AlumnosContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
    }
}
