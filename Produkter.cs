namespace IProductService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produkter")]
    public partial class Produkter
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Märke { get; set; }

        [Required]
        [StringLength(50)]
        public string Modell { get; set; }

        public int? Serienummer { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Årsmodell { get; set; }
    }
}
