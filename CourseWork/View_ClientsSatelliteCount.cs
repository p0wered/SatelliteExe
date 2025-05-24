namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_ClientsSatelliteCount
    {
        [Key]
        [StringLength(40)]
        public string Клиент { get; set; }

        public int? Количество_спутников { get; set; }
    }
}
