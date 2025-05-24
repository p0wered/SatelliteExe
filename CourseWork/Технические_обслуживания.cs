namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Технические_обслуживания
    {
        [Key]
        public int Номер_ТО { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата_проведения { get; set; }

        [StringLength(20)]
        public string Длительность { get; set; }

        public int Номер_бригады { get; set; }

        public int Идентификатор_спутника { get; set; }

        public virtual Бригады_специалистов Бригады_специалистов { get; set; }

        public virtual Спутники Спутники { get; set; }
    }
}
