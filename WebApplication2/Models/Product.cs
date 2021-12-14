using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }
       
        public string Ad { get; set; }
        public string Resim { get; set; }
        
        [NotMapped]
        [DisplayName("Upload File")]
       public IFormFile ImageFile { get; set; }

        public int Fiyat { get; set; }
        public int indirim { get; set; }
        public int MarkaId { get; set; }
        public int IndirimId { get; set; }
        public int indirimliFiyat { get; set; }
        public string Aciklama { get; set; }
        
        public int? KategoriId { get; set; }
        [ForeignKey("KategoriId")]
        public Kategori Kategori { get; set; }

        
        public Marka Marka { get; set; }
    
        public Indirim Indirim { get; set; }
    }
    
}
