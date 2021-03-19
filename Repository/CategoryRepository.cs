using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA20.interfaces;
using WA20.Models;

namespace WA20.Repository
{
    public class CategoryRepository : IRealtyCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
