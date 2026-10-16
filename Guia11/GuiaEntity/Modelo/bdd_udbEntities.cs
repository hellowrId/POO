using System.Data.Entity;

namespace GuiaEntity.Modelo
{
    // Contexto de Entity Framework; usa la cadena "bdd_udbEntities" de App.config
    public partial class bdd_udbEntities : DbContext
    {
        public bdd_udbEntities() : base("name=bdd_udbEntities")
        {
            // La base ya existe: no crear ni migrar nada
            Database.SetInitializer<bdd_udbEntities>(null);
        }

        public virtual DbSet<Persona> Persona { get; set; }
    }
}
