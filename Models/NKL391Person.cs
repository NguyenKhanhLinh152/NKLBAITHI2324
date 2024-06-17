using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NKLBAITHI2324.Models
{
    [Table("NKL391Person")]
    public class NKL391Person
    {
        [Key]
        public int Ngaysinh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        
    }
}