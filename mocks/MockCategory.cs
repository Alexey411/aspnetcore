using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA20.interfaces;
using WA20.Models;

namespace WA20.mocks
{
    public class MockCategory : IRealtyCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ categoryName = "Вторички"},
                    new Category{ categoryName = "Новостройки"},
                    new Category{ categoryName = "Коммерческая"},
                    new Category{ categoryName = "Аренда"}

                };
            }
        }
    }
}
