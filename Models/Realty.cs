using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WA20.Models
{
    public class Realty
    {
        public int id { set; get; }
        public string room { set; get; }
        public string floor { set; get; }
        public string squares { set; get; }
        public string adress { set; get; }
        public string metro { set; get; }
        public string img { set; get; }
        public uint price { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string phone { get; set; }
        public bool isFavourite { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
