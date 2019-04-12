using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BH.Areas.Admin.Models
{
    [Serializable]
    public class ProductModel
    {
        public int IDPro { get; set; }
        public string tensanpham { get; set; }
        public decimal? gia { get; set; }
    }
}