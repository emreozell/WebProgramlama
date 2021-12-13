using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
       
        public string Ad { get; set; }
        public string Resim { get; set; }

        public string MarkaAd { get; set; }
        public int Fiyat { get; set; }
        public int indirim { get; set; }
        public int indirimliFiyat { get; set; }
        public string Aciklama { get; set; }

        public Kategori Kategori { get; set; }
        public Marka Marka { get; set; }
        public Indirim Indirim { get; set; }
    }
}
