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

        public ActionResult Register(int id)
        {
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }

            OrderSummaryViewModel vm = new OrderSummaryViewModel();

            vm.EventId = id;

            return View(vm);
        }

        public ActionResult OrderSummary()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddOrder(OrderSummaryViewModel vm)
        {
            OrderCart order = OrderCart.GetCart(this.HttpContext);

            int q = vm.SelectedOrderTicketQuantity;

            order.AddToCart(vm.EventId, q);

            return Redirect("Index");
        }

        public ActionResult RemoveOrder(int id)
        {


            
            return null;
        }
    }
}