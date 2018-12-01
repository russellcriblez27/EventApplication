using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventApplication.Models;
using EventApplication.Models.ViewModels;

namespace EventApplication.Controllers
{
    public class OrderController : Controller
    {
       
        private EventDb db = new EventDb();

        // GET: Order
        public ActionResult Index()
        {

            OrderCart cart = OrderCart.GetCart(this.HttpContext);
            OrderCartViewModel vm = new OrderCartViewModel()
            {
                OrderItems = cart.GetCartItems()
            };
            return View(vm);
        }

        public ActionResult Register(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }



            return View(@event);
        }

        public ActionResult OrderSummary()
        {

            return View();
        }

        public ActionResult AddOrder(int id, int quantity)
        {
            OrderCart order = OrderCart.GetCart(this.HttpContext);

            order.AddToCart(id, quantity);

            return Redirect("Index");
        }

        public ActionResult RemoveOrder(int id)
        {


            
            return null;
        }
    }
}