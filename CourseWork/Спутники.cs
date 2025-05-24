namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Спутники
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Спутники()
        {
            Сбои = new HashSet<Сбои>();
            Технические_обслуживания = new HashSet<Технические_обслуживания>();
        }

        [Key]
        public int Идентификатор_спутника { get; set; }

        [Required]
        [StringLength(10)]
        public string Название { get; set; }

        [Required]
        [StringLength(20)]
        public string Статус { get; set; }

        public int Срок_службы { get; set; }

        public int Идентификатор_орбиты { get; set; }

        public int Номер_операции { get; set; }

        public int Станция_вылета { get; set; }

        [Required]
        [StringLength(40)]
        public string Клиент { get; set; }

        public virtual Клиентские_компании Клиентские_компании { get; set; }

        public virtual Наземные_станции Наземные_станции { get; set; }

        public virtual Операции Операции { get; set; }

        public virtual Орбиты Орбиты { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сбои> Сбои { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Технические_обслуживания> Технические_обслуживания { get; set; }
    }
}
