using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA20.Models;

namespace WA20.interfaces
{
    public interface IRealtyCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
