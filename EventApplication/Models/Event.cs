using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class Event
    {

        public virtual int EventId { get; set; }

        public virtual int EventTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public virtual string Title { get; set; }

        [MaxLength(150)]
        public virtual string Description { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        //Can not be in the past
        public virtual DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        //Can not be before StartDate
        public virtual DateTime EndDate { get; set; }

        [Required]
        public virtual string City { get; set; }

        [Required]
        public virtual string State { get; set; }

        public virtual EventType EventType { get; set; }

        [Required]
        [Display(Name = "Organizer")]
        public virtual string OrganizationName { get; set; }

        [Display(Name = "Organizer Contact Info")]
        public virtual string OrganizationContactInfo { get; set; }

        [Required]
        [Display(Name = "Max Tickets")]
        [Range(0, int.MaxValue)]
        public virtual int MaxTickets { get; set; }

        [Required]
        [Display(Name = "Available Tickets")]
        [Range(0, int.MaxValue)]
        public virtual int AvailableTickets { get; set; }
    }
}