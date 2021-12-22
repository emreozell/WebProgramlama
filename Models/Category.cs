using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebOdev.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string  CategoryName { get; set; }
      

        public List<Food> Foods { get;set; }
    }
}
