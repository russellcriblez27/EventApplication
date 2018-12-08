using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventApplication.Models.ViewModels
{
    public class OrderSummaryViewModel
    {
        public OrderSummaryViewModel()
        {
            this.@event = new Event();
        }

        public int EventId { get; set; }
        public Event @event { get; set; }
        public int SelectedOrderTicketQuantity { get; set; }
    }
}