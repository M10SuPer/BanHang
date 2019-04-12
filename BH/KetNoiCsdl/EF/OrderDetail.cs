namespace KetNoiCsdl.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDOrD { get; set; }

        public int? IDOr { get; set; }

        [StringLength(70)]
        public string tennguoidathang { get; set; }

        [StringLength(70)]
        public string email { get; set; }

        [StringLength(200)]
        public string diachi { get; set; }

        [StringLength(20)]
        public string sdt { get; set; }

        public virtual OrderA OrderA { get; set; }
    }
}
