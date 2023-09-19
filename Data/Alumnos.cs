using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AluSetInstance.Data
{
    [Table("ALUMNOS_WEB")]
    public class Alumnos
    {
        [Key]
        [Required]
        [Column("ID")] 
        public int Id { get; set; }
       
        [Required]
        [Column("ALUMNO_ID")] 
        public string AlumnoId { get; set; } = default!;

        [Required]
        [Column("ALUMNO_MAIL")] 
        public string AlumnoMail { get; set; } = default!;

        [Required]
        [Column("ALUMNO_DOCUMENTO")] 
        public string AlumnoDocumento { get; set; } = default!;

        [Required]
        [Column("CARRERA_ID")] 
        public string CarreraId { get; set; } = default!;

        [Column("ALUMNO_NOMBRE")]         
        public string? AlumnoNombre { get; set; } = default!;
        [Column("ALUMNO_APELLIDO")]         
        public string? AlumnoApellido { get; set; } = default!;

        [Column("CARRERA_NOMBRE")]         
        public string? CarreraNombre { get; set; } = default!;

        [Column("HAVEUSER")]         
        public bool HaveUser { get; set; } = default!;
    }
}

/*
*/