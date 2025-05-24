namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Клиентские_компании
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Клиентские_компании()
        {
            Спутники = new HashSet<Спутники>();
        }

        [Key]
        [StringLength(40)]
        public string Название { get; set; }

        [StringLength(40)]
        public string Сфера { get; set; }

        public int Количество_сотрудников { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата_заключения_договора { get; set; }

        public int Длительность_договора { get; set; }

        [StringLength(16)]
        public string Контактный_телефон { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спутники> Спутники { get; set; }
    }
}
