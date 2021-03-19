using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA20.interfaces;
using WA20.ViewModels;

namespace WA20.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllRealty _realtyRep;

        public HomeController(IAllRealty realRep)
        {
            _realtyRep = realRep;
        }
        public ViewResult Index()
        {
            var homeRealty = new HomeViewModel
            {
                favRealty = _realtyRep.getFavRealty
            };
            return View(homeRealty);
        }
    }
}
