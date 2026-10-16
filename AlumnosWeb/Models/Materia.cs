using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlumnosWeb.Models
{
    [Table("Materias", Schema = "dbo")]
    public class Materia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string? nombre { get; set; }
    }
}
