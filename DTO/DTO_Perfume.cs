using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_DangNgocYenNhi_2190994_DTO
{
    public class DTO_Perfume
    {
        public int IdPerfume { get; set; }
        public string NamePerfume { get; set; }
        public string Brand { get; set; }
        public string Origin { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public DTO_Perfume() { }
    }
}