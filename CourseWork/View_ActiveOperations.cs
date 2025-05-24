namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_ActiveOperations
    {
        [Key]
        [Column(Order = 0)]
        public int Номер_операции { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string Операция { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime Дата_начала { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string Компания_организатор { get; set; }
    }
}
