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
    [Authorize]
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

            vm.@event = db.Events.Find(id);
            vm.EventId = id;

            return View(vm);
        }

        public ActionResult OrderSummary(int orderNumber)
        {
            OrderCart order = OrderCart.GetCart(this.HttpContext);
            Order o = order.GetOrder(orderNumber);
            return View(o);
        }

        [HttpPost]
        public ActionResult AddOrder(OrderSummaryViewModel vm)
        {
            OrderCart order = OrderCart.GetCart(this.HttpContext);

            int q = vm.SelectedOrderTicketQuantity;

            if (q > 0)
            {
                //adds to cart and gets order number
                int oNumber = order.AddToCart(vm.EventId, q);
                if (oNumber > 0)
                {
                    return RedirectToAction("OrderSummary", new { orderNumber = oNumber });
                }
            }
            return Redirect("Index");
        }

        [HttpPost]
        public ActionResult RemoveOrder(int id)
        {
            OrderCart order = OrderCart.GetCart(this.HttpContext);
            string eventTitle = db.Orders.SingleOrDefault(o => o.OrderId == id).Events.Title;
            order.RemoveFromCart(id);

            OrderCartRemoveViewModel vm = new OrderCartRemoveViewModel()
            {
                DeleteId = id,
                Message = "Your order for " + eventTitle + " has been cancelled."
            };

            return Json(vm);
        }
    }
}