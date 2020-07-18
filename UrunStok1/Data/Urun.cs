using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UrunStok1.Data
{
    public class Urun
    {
        [Key]
        public int Id { get; set; }

        public string UrunAdi { get; set; }
        public int Stok { get; set; }
        public string Aciklama { get; set; }
        public double Fiyat { get; set; }
    }
}
