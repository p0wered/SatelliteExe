namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Бригады_специалистов
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Бригады_специалистов()
        {
            Технические_обслуживания = new HashSet<Технические_обслуживания>();
        }

        [Key]
        public int Номер_бригады { get; set; }

        public int Количество_специалистов { get; set; }

        public decimal Стаж { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Технические_обслуживания> Технические_обслуживания { get; set; }
    }
}
