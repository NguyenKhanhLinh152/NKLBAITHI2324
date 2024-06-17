using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NKLBAITHI2324.Models
{
    [Table("NKL391Person")]
    public class NKL391Employee
    {
        [Key]
        public int MaSinhVien { get; set; }
        public int NgaySinh { get; set; }
        [ForeignKey("Ngaysinh")]
        public NKL391Person NKL391Person { get; set; }

    }
}