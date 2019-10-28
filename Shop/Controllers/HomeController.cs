using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private IAllGoods _goodsRep;

        public HomeController(IAllGoods goodsRep)
        {
            _goodsRep = goodsRep;
        }

        public ViewResult Index()
        {
            var homeGoods = new HomeViewModel
            {
                favGoods = _goodsRep.getFavGoods
            };

            return View(homeGoods);
        }
    }
}
