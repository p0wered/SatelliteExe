namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Космические_компании
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Космические_компании()
        {
            Операции = new HashSet<Операции>();
        }

        [Key]
        [StringLength(40)]
        public string Название { get; set; }

        [Required]
        [StringLength(25)]
        public string Страна { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Дата_основания { get; set; }

        public int Количество_сотрудников { get; set; }

        [StringLength(16)]
        public string Контактный_телефон { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Операции> Операции { get; set; }
    }
}
