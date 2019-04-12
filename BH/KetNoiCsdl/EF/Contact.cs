namespace KetNoiCsdl.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDC { get; set; }

        [StringLength(70)]
        public string tennguoilienhe { get; set; }

        [StringLength(70)]
        public string email { get; set; }

        [StringLength(20)]
        public string sdt { get; set; }

        [Column(TypeName = "text")]
        public string noidung { get; set; }
    }
}
