namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ресурсы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ресурсы()
        {
            Ресурсы_Операции = new HashSet<Ресурсы_Операции>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(40)]
        public string Название { get; set; }

        public int Количество { get; set; }

        [StringLength(8)]
        public string Единица_измерения { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ресурсы_Операции> Ресурсы_Операции { get; set; }
    }
}
