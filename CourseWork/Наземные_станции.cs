namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Наземные_станции
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Наземные_станции()
        {
            Спутники = new HashSet<Спутники>();
        }

        [Key]
        public int Номер_станции { get; set; }

        [Required]
        [StringLength(40)]
        public string Название { get; set; }

        [Required]
        [StringLength(20)]
        public string Страна { get; set; }

        public int Количество_антенн { get; set; }

        public int Идентификатор_оператора { get; set; }

        public virtual Штабы_управления Штабы_управления { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Спутники> Спутники { get; set; }
    }
}
