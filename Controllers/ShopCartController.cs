using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA20.interfaces;
using WA20.Models;
using WA20.Repository;
using WA20.ViewModels;

namespace WA12.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllRealty _realtyRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllRealty realRep, ShopCart shopCart)
        {
            _realtyRep = realRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _realtyRep.Realty.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}