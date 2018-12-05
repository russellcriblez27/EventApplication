using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventApplication.Models.ViewModels
{
    public class OrderSummaryViewModel
    {
        public int EventId;
        public Event @event;
        public SelectList OrderTicketQuantity = new SelectList(new List<SelectListItem>
        {
            new SelectListItem{ Selected = true, Text = "1", Value = "1" },
            new SelectListItem{ Selected = true, Text = "2", Value = "2" },
            new SelectListItem{ Selected = true, Text = "3", Value = "3" },
            new SelectListItem{ Selected = true, Text = "4", Value = "4" },
            new SelectListItem{ Selected = true, Text = "5", Value = "5" },
            new SelectListItem{ Selected = true, Text = "6", Value = "6" },
            new SelectListItem{ Selected = true, Text = "7", Value = "7" },
            new SelectListItem{ Selected = true, Text = "8", Value = "8" },
            new SelectListItem{ Selected = true, Text = "9", Value = "9" },
            new SelectListItem{ Selected = true, Text = "10", Value = "10" }
        });
        public int SelectedOrderTicketQuantity { get; set; }
    }
}