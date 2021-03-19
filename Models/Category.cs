using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WA20.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public List<Realty> realty { get; set; }
    }
}
