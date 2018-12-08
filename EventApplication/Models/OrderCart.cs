using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class OrderCart
    {
        public string OrderCartId;
        private const string CartSessionKey = "CartId";

        EventDb db = new EventDb();

        public static OrderCart GetCart(HttpContextBase context)
        {
            OrderCart cart = new OrderCart();
            cart.OrderCartId = cart.GetCartId(context);
            return cart;
        }

        public string GetCartId(HttpContextBase context)
        {
            string cartId;

            if (context.Session[CartSessionKey] == null)
            {
                //Create a cart id and add it to the session variable
                cartId = Guid.NewGuid().ToString();
                context.Session[CartSessionKey] = cartId;
            }
            else
            {
                //retrive CartId
                cartId = context.Session[CartSessionKey].ToString();
            }
            return cartId;
        }

        public List<Order> GetCartItems()
        {
            return db.Orders.Where(cart => cart.CartId == OrderCartId).ToList();
        }
        
        public int AddToCart(int id, int ticketQuantity)
        {

            //add order to db
            int orderNumber;
            Event orderedEvent = db.Events.Find(id);

            Event @event = db.Events.SingleOrDefault(a => a.EventId == id);
            Random rnd = new Random();
            orderNumber = rnd.Next(5910253, 90561206);
            if (((@event.AvailableTickets - ticketQuantity) >= 0) && @event.StartDate > DateTime.Now)
            {
                Order orderItem = new Order()
                {
                    CartId = OrderCartId,
                    OrderNumber = orderNumber,
                    EventId = id,
                    Events = @event,
                    Status = "Processed",
                    NumberOfTickets = ticketQuantity,
                    DateOrdered = DateTime.Now
                };
                db.Orders.Add(orderItem);
                //changes available quantity
                orderedEvent.AvailableTickets = orderedEvent.AvailableTickets - ticketQuantity;
                db.SaveChanges();
            }
            else
            {
                orderNumber = -1;
            }
            return orderNumber;
        }
        public Order GetOrder(int oNumber)
        {
            Order thisOrder = db.Orders.SingleOrDefault(o => o.CartId == OrderCartId && o.OrderNumber == oNumber);
            return thisOrder;
        }

        public void RemoveFromCart(int id)
        {
            Order cartItem = db.Orders.SingleOrDefault(cart => cart.OrderId == id);
            Event orderedEvent = db.Events.Find(id);
            if (cartItem != null && cartItem.Status != "Cancelled")
            {
                //change status to cancelled
                cartItem.Status = "Cancelled";
                //update available tickets for event
                orderedEvent.AvailableTickets = orderedEvent.AvailableTickets + cartItem.NumberOfTickets;
                //leave ticket value alone
                db.SaveChanges();
            }
        }
    }
}