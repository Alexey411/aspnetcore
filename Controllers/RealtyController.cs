using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WA20.interfaces;
using WA20.Models;
using WA20.ViewModels;

namespace WA12.Controllers
{
    public class RealtyController : Controller
    {
        private readonly IAllRealty _allRealty;
        private readonly IRealtyCategory _allCategories;

        public RealtyController(IAllRealty iAllRealty, IRealtyCategory iRealtyCat)
        {
            _allRealty = iAllRealty;
            _allCategories = iRealtyCat;
        }

        [Route("Realty/List")]
        [Route("Realty/List/{category}")]
        public ViewResult List(string category, int id)
        {
            string _category = category;
            IEnumerable<Realty> realty = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                realty = _allRealty.Realty.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("Newbuilding", category, StringComparison.OrdinalIgnoreCase))
                {
                    realty = _allRealty.Realty.Where(i => i.Category.categoryName.Equals("Новостройки")).OrderBy(i => i.id);
                    currCategory = "Новостройки";
                }
                else if (string.Equals("Secondaryschools", category, StringComparison.OrdinalIgnoreCase))
                {
                    realty = _allRealty.Realty.Where(i => i.Category.categoryName.Equals("Вторичка")).OrderBy(i => i.id);
                    currCategory = "Вторички";
                }
                else if (string.Equals("Commercial", category, StringComparison.OrdinalIgnoreCase))
                {
                    realty = _allRealty.Realty.Where(i => i.Category.categoryName.Equals("Коммерческая")).OrderBy(i => i.id);
                    currCategory = "Коммерческая";
                }
                else if (string.Equals("Rent", category, StringComparison.OrdinalIgnoreCase))
                {
                    realty = _allRealty.Realty.Where(i => i.Category.categoryName.Equals("Аренда")).OrderBy(i => i.id);
                    currCategory = "Аренда";
                }

                currCategory = _category;     
            }

            var realtyobj = new RealtyListViewModel
            {
                allRealty = realty,
                currCategory = currCategory
            };


            ViewBag.Title = "Недвижимость";


            return View(realtyobj);
        }
    }
}