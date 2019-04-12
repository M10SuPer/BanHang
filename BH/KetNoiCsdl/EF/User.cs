namespace KetNoiCsdl.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required(ErrorMessage = "Ban chua nhap UserName")]
        [StringLength(70)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Ban chua nhap Password")]
        [StringLength(70)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Ban chua nhap Name")]
        [StringLength(70)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ban chua nhap Address")]
        [StringLength(70)]
        public string Address { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
