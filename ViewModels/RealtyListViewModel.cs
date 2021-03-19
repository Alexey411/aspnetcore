using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA20.Models;

namespace WA20.ViewModels
{
    public class RealtyListViewModel
    {
        public IEnumerable<Realty> allRealty { get; set; }
        public string currCategory { get; set; }
    }
}
