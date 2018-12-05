using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventApplication.Models
{
    public class SampleData : DropCreateDatabaseAlways<EventDb>
    {
        protected override void Seed(EventDb context)
        {
            var eventTypes = new List<EventType>
            {
                new EventType { Type = "Concert"},
                new EventType { Type = "Convention"},
                new EventType { Type = "FurMeet"},
                new EventType { Type = "Rave"},
                new EventType { Type = "Dance"},
                new EventType { Type = "Tabletop RPG Sessions"}
            };
            new List<Event>
            {
                new Event { Title = "Con on the Cob 2019", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Table top gameing convention.",
                            StartDate = DateTime.Parse("10/03/2019 9:00:00"),
                            EndDate = DateTime.Parse("10/06/2019 1:30:00 PM"),
                            City = "Richfield", State = "Ohio",
                            OrganizationName = "Con on the Cob", OrganizationContactInfo = "Phone: 330-285-1530 (Andy)",
                            MaxTickets = 700, AvailableTickets = 400
                          },
                new Event { Title = "Con on the Cob 2018", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Table top gameing convention.",
                            StartDate = DateTime.Parse("10/03/2018 9:00:00"),
                            EndDate = DateTime.Parse("10/06/2018 1:30:00 PM"),
                            City = "Richfield", State = "Ohio",
                            OrganizationName = "Con on the Cob", OrganizationContactInfo = "Phone: 330-285-1530 (Andy)",
                            MaxTickets = 700, AvailableTickets = 400
                          },
                new Event { Title = "Ohayocon 2019", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Anime convention.",
                            StartDate = DateTime.Parse("01/11/2019 9:00:00"),
                            EndDate = DateTime.Parse("01/13/2019 1:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "Ohayocon", OrganizationContactInfo = "",
                            MaxTickets = 18000, AvailableTickets = 10000
                          },
                new Event { Title = "Pathfinder Session New Campaing Members Welcome", EventType = eventTypes.Single(e => e.Type == "Tabletop RPG Sessions"),
                            Description = "Pathfinder Heroic campaign sessions to be held at local store. New members welcome only first meetup listed future sessions TBD during first session.",
                            StartDate = DateTime.Parse("12/11/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/11/2018 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "GamestoreB", OrganizationContactInfo = "bs",
                            MaxTickets = 8, AvailableTickets = 3
                          },
                new Event { Title = "Last Minute Deal Test", EventType = eventTypes.Single(e => e.Type == "Tabletop RPG Sessions"),
                            Description = "Test for last minute deals",
                            StartDate = DateTime.Parse("12/05/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/05/2018 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "NA", OrganizationContactInfo = "",
                            MaxTickets = 10, AvailableTickets = 10
                          },

            }.ForEach(e => context.Events.Add(e));

            base.Seed(context);
        }
    }
}