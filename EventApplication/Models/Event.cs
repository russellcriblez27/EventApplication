using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using EventApplication.Validation;

namespace EventApplication.Models
{
    public class Event : IValidatableObject
    {

        public virtual int EventId { get; set; }

        public virtual int EventTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public virtual string Title { get; set; }

        [MaxLength(150)]
        public virtual string Description { get; set; }

        [Required]
        //[ValidateStartDate(ErrorMessage = "DerpDate")] //fails on loading db. alt method used.
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        //Can not be in the past
        public virtual DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public virtual DateTime EndDate { get; set; }

        [Required]
        public virtual string City { get; set; }

        [Required]
        [RegularExpression("([a-zA-Z-]+)", ErrorMessage = "Please type a state name.")]
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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //check if start date is after current date
            //if (StartDate < DateTime.Now)
            //{
            //    //error
            //    yield return new ValidationResult("Start Date must be in the future.", new[] { "StartDate" });
            //}

            //check if end date is after start date 
            if (EndDate < StartDate)
            {
                //error
                yield return new ValidationResult("End Date must be after Start Date.", new[] { "EndDate" });
            }
            if (AvailableTickets > MaxTickets)
            {
                //error
                yield return new ValidationResult("Available tickets can not be greater than Max tickets.", new[] { "AvailableTickets" });
            }
            
        }
    }
}