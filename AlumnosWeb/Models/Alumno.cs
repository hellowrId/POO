using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlumnosWeb.Models
{
    [Table("alumnos", Schema = "alumno")]
    public class Alumno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int carnet { get; set; }
        public string? nombres { get; set; }
        public string? apellidos { get; set; }
    }
}
