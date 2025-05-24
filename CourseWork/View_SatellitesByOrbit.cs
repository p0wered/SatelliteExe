namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_SatellitesByOrbit
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Идентификатор_спутника { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Спутник { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string Тип_орбиты { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal Высота { get; set; }
    }
}
