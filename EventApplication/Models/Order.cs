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
        [Key]
        public virtual int OrderId { get; set; }

        public string CartId { get; set; } //Not unique

        public virtual int NumberOfTickets { get; set; }

        public virtual DateTime DateOrdered { get; set; }

        public virtual int EventId { get; set; }

        public virtual Event events { get; set; }

        public virtual string status { get; set; }

    }
}