using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL_1721050561.Models
{
    public class NHACUNGCAP
    {
        [Key]
        [Required, MaxLength(20)]
        public int MaNhaMaNhaCungCap { get; set; }
        [Required, MaxLength(50)]
        public string TenKhTenNhaCungCapoa { get; set; }
    }
}