namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Операции
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Операции()
        {
            Ресурсы_Операции = new HashSet<Ресурсы_Операции>();
            Спутники = new HashSet<Спутники>();
        }

        [Key]
        public int Номер_операции { get; set; }

        [Required]
        [StringLength(40)]
        public string Название { get; set; }

        [Required]
        [StringLength(20)]
        public string Статус { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата_начала { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Дата_окончания { get; set; }

        [Required]
        [StringLength(40)]
        public string Компания_организатор { get; set; }

        public virtual Космические_компании Космические_компании { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ресурсы_Операции> Ресурсы_Операции { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спутники> Спутники { get; set; }
    }
}
