namespace CrudMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("perfil")]
    public partial class Perfil
    {
        [Key]
        public int id_perfil { get; set; }

        [StringLength(20)]
        public string nombre { get; set; }
    }
}
