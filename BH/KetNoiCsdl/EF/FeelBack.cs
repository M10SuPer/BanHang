namespace KetNoiCsdl.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FeelBack")]
    public partial class FeelBack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDF { get; set; }

        [StringLength(70)]
        public string email { get; set; }
    }
}
