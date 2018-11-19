namespace CrudMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("persona")]
    public partial class Persona
    {
        [Key]
        public int id_persona { get; set; }

        public int? id_perfil { get; set; }

        public int? documento { get; set; }

        [StringLength(25)]
        public string nombre { get; set; }

        [StringLength(25)]
        public string apellido { get; set; }

        [StringLength(25)]
        public string direccion { get; set; }

        [StringLength(25)]
        public string telefono { get; set; }

        [StringLength(60)]
        public string email { get; set; }

        [StringLength(20)]
        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string usuario { get; set; }

        [StringLength(60)]
        [Required(ErrorMessage = "La {0} es obligatorio")]
        public string clave { get; set; }

        public DateTime? fecha_registro { get; set; }

        [StringLength(1)]
        public string estado { get; set; }

        public virtual Perfil perfil { get; set; }
    }
}
