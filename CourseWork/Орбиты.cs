namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Орбиты
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Орбиты()
        {
            Спутники = new HashSet<Спутники>();
        }

        [Key]
        public int Идентификатор_орбиты { get; set; }

        [Required]
        [StringLength(30)]
        public string Тип_орбиты { get; set; }

        public decimal Высота { get; set; }

        public decimal? Период_обращения { get; set; }

        public decimal? Градус_наклона { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спутники> Спутники { get; set; }
    }
}
