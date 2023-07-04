using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AluSetInstance.Data
{
    [Table("INSCRIPCION_FINALES_WEB")]
    public class InscripcionMaterias
    {

        [Key]
        [Required]
        [Column("ID")] 
        public int Id { get; set; }
       
        [Required]
        [Column("ALUMNO_ID")] 
        public int AlumnoId { get; set; } = default!;

        [Required]
        [Column("ALUMNO_DOCUMENTO")] 
        public string AlumnoDocumento { get; set; } = default!;

        [Required]
        [Column("CARRERA_ID")] 
        public string CarreraId { get; set; } = default!;

        [Required]
        [Column("MATERIA_ID")] 
        public string MateriaId { get; set; } = default!;
        
        [Required]
        [DataType(DataType.Date)]
        [Column("FECHA")]         
        public DateTime Fecha { get; set; } = default!;        

        [Column("ALUMNO_NOMBRE")]         
        public string? AlumnoNombre { get; set; } = default!;

        [Column("CARRERA_NOMBRE")]         
        public string? CarreraNombre { get; set; } = default!;
        
        [Column("MATERIA_NOMBRE")]         
        public string? MateriaNombre { get; set; } = default!;
        
        [Column("ADM_OK")]         
        public bool AdmOk { get; set; }

        [Column("SECDOC_OK")]         
        public bool SecdocOk { get; set; }

        [Column("PLATAFORMA_OK")]         
        public bool PlataformaOk { get; set; } 

        [Column("INDCURSADA")]         
        public int? IdCursada { get; set; } = default!;

    }
}

/*CREATE OR ALTER VIEW INSCRIPCION_FINALES_WEB(
    ID,
    MESA,
    LLAMADO,
    ALUMNO_ID,
    ALUMNO_NOMBRE,
    CUATRIMESTRE_TURNO_COMISION,
    CARRERA_ID,
    CARRERA_NOMBRE,
    MATERIA_ID,
    MATERIA_NOMBRE,
    FECHA_EXAMEN,
    FECHA_EMISION,
    PERMISO_ID,
    ADM_OK,
    SECDOC_OK,
    PLATAFORMA_OK)
AS
SELECT W.INDICE, W.MESA, W.LLAMADO, W.ALUMNO_ID, TRIM(A.APELLIDO)||', '||TRIM(A.NOM_APE),W.CUTUCO, W.CARRE,
       C.DESCARRE, W.COD_MAT, M.DESCRIPCI, W.FECH_EXA, W.FECH_EMI, W.PERMEXA_ID,
       W.ADM_OK, W.SECDOC_OK, W.PLATAFORMA_OK
FROM WEB_PERMEXA W
LEFT OUTER JOIN ALUMNOS A ON A.INDICE=W.ALUMNO_ID
LEFT OUTER JOIN CARRERA C ON C.CARRE=W.CARRE
LEFT OUTER JOIN MATERIAS M ON M.CODMATERI=W.COD_MAT AND M.CODCARRE=W.CARRE
;

ALTER TABLE WEB_PERMEXA
ADD ADM_OK BOOLEAN DEFAULT FALSE NOT NULL  ,
ADD SECDOC_OK BOOLEAN DEFAULT FALSE NOT NULL  ,
ADD PLATAFORMA_OK BOOLEAN DEFAULT FALSE NOT NULL
*/