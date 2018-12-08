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

        [Display(Name = "Number of Tickets")]
        public virtual int OrderNumber { get; set; }

        public string CartId { get; set; } //Not unique

        [Display(Name = "Number of Tickets")]
        public virtual int NumberOfTickets { get; set; }

        public virtual DateTime DateOrdered { get; set; }

        public virtual int EventId { get; set; }

        public virtual Event Events { get; set; }

        public virtual string Status { get; set; }

    }
}