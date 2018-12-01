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
        
        public void AddToCart(int id, int ticketQuantity)
        {

            //CartItem does not exist in db. add to db
            Order cartItem = db.Orders.SingleOrDefault(c => c.CartId == OrderCartId && c.EventId == id);

            if (cartItem == null)
            {
                Event @event = db.Events.SingleOrDefault(a => a.EventId == id);
                cartItem = new Order()
                {
                    CartId = OrderCartId,
                    EventId = id,
                    @event = @event,
                    NumberOfTickets = ticketQuantity,
                    DateOrdered = DateTime.Now
                };
                db.Orders.Add(cartItem);
            }
            else
            {
                //CartItem exists already in db. update count
                cartItem.NumberOfTickets = cartItem.NumberOfTickets + ticketQuantity;
            }
            db.SaveChanges();
        }
        public int RemoveFromCart(int id)
        {
            Order cartItem = db.Orders.SingleOrDefault(cart => cart.OrderId == id);
            int count = 0;
            if (cartItem != null)
            {
                db.Orders.Remove(cartItem);
                db.SaveChanges();
            }
            return count;
        }
    }
}