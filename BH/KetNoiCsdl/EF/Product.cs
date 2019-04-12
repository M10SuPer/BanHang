namespace KetNoiCsdl.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderAs = new HashSet<OrderA>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDPro { get; set; }

        [Required(ErrorMessage ="Ban Chua Nhap Ten")]
        [StringLength(70)]
        [Display(Name="Ten San Pham")]
        public string tensanpham { get; set; }
        [Required(ErrorMessage = "Ban Chua Nhap Gia")]
        [Display(Name = "Gia San Pham")]
        public decimal? gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderA> OrderAs { get; set; }
    }
}
