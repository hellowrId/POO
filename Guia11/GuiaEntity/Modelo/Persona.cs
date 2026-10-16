using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuiaEntity.Modelo
{
    // Clase que representa la tabla persona de bdd_udb
    [Table("persona")]
    public partial class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string correo { get; set; }

        public DateTime? fecha_nacimiento { get; set; }
    }
}
