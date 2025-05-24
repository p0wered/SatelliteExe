namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Штабы_управления
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Штабы_управления()
        {
            Наземные_станции = new HashSet<Наземные_станции>();
        }

        [Key]
        public int Идентификатор_штаба { get; set; }

        public int Количество_сотрудников { get; set; }

        [Required]
        [StringLength(20)]
        public string Страна { get; set; }

        [Required]
        [StringLength(20)]
        public string Уровень_безопасности { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Наземные_станции> Наземные_станции { get; set; }
    }
}
