namespace KetNoiCsdl.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(70)]
        public string tenncc { get; set; }

        [StringLength(200)]
        public string diachi { get; set; }

        [StringLength(70)]
        public string email { get; set; }

        [StringLength(20)]
        public string sdt { get; set; }
    }
}
