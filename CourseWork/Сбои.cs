namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сбои
    {
        [Key]
        public int Номер_сбоя { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата_сбоя { get; set; }

        public int Идентификатор_спутника { get; set; }

        [Required]
        [StringLength(40)]
        public string Оборудование { get; set; }

        [StringLength(20)]
        public string Уровень_серьезности { get; set; }

        public virtual Спутники Спутники { get; set; }
    }
}
