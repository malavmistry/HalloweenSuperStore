using Ch24ShoppingCartMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch24ShoppingCartMVC.Controllers
{
    public class CheckOutController : Controller
    {
        //
        // GET: /CheckOut/

        private CartModel cart = new CartModel();

        public ActionResult Index()
        {
            CartViewModel model = (CartViewModel)TempData["cart"];
            if (model == null)
            {
                model = cart.GetCart();
            }
            //Passing model to View
            return View(model);
        }
    }
}
