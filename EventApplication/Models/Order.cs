using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class Order
    {
        public virtual int OrderId { get; set; }

        public virtual int NumberOfTickets { get; set; }

        public virtual DateTime DateOrdered { get; set; }

        public virtual string EventId { get; set; }

        public virtual Event Event { get; set; }

    }
}