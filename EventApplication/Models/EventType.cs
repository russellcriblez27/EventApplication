using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class EventType
    {

        public virtual int EventTypeId { get; set; }

        [MaxLength(50)]
        public virtual string Type { get; set; }
    }
}