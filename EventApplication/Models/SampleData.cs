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
                new EventType { Type = "Tabletop RPG Sessions"},
                new EventType { Type = "Group up"},
                new EventType { Type = "Movie Night"},
                new EventType { Type = "Theatrical Play"},
                new EventType { Type = "Ballet"},
                new EventType { Type = "Children's Event"},
                new EventType { Type = "Tea Party"},
                new EventType { Type = "Classic Car Show"},
                new EventType { Type = "Musical"},
                new EventType { Type = "Gathering"},
                new EventType { Type = "Resale"},
                new EventType { Type = "Movie Magic"}
            };
            new List<Event>
            {
                new Event { Title = "Con on the Cob 2019", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Table top gaming convention.",
                            StartDate = DateTime.Parse("10/03/2019 9:00:00"),
                            EndDate = DateTime.Parse("10/06/2019 1:30:00 PM"),
                            City = "Richfield", State = "Ohio",
                            OrganizationName = "Con on the Cob", OrganizationContactInfo = "Phone: 330-285-1530 (Andy)",
                            MaxTickets = 700, AvailableTickets = 400
                          },
                new Event { Title = "Con on the Cob 2018", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Table top gaming convention.",
                            StartDate = DateTime.Parse("10/03/2018 9:00:00"),
                            EndDate = DateTime.Parse("10/06/2018 1:30:00 PM"),
                            City = "Richfield", State = "Ohio",
                            OrganizationName = "Con on the Cob", OrganizationContactInfo = "Phone: 330-285-1530 (Andy)",
                            MaxTickets = 700, AvailableTickets = 400
                          },
                new Event { Title = "Con on the Cob 2017", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Table top gaming convention.",
                            StartDate = DateTime.Parse("10/03/2017 9:00:00"),
                            EndDate = DateTime.Parse("10/06/2017 1:30:00 PM"),
                            City = "Richfield", State = "Ohio",
                            OrganizationName = "Con on the Cob", OrganizationContactInfo = "Phone: 330-285-1530 (Andy)",
                            MaxTickets = 700, AvailableTickets = 400
                          },
                new Event { Title = "Con on the Cob 2016", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Table top gameing convention.",
                            StartDate = DateTime.Parse("10/03/2016 9:00:00"),
                            EndDate = DateTime.Parse("10/06/2016 1:30:00 PM"),
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
                //events 6-10
                new Event { Title = "Ohayocon 2018", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Anime convention.",
                            StartDate = DateTime.Parse("01/11/2018 9:00:00"),
                            EndDate = DateTime.Parse("01/13/2018 1:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "Ohayocon", OrganizationContactInfo = "",
                            MaxTickets = 18000, AvailableTickets = 10000
                          },
                new Event { Title = "Ohayocon 2017", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "Anime convention.",
                            StartDate = DateTime.Parse("01/11/2017 9:00:00"),
                            EndDate = DateTime.Parse("01/13/2017 1:30:00 PM"),
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
                new Event { Title = "Last Minute Deal Test 01 Alpha", EventType = eventTypes.Single(e => e.Type == "Tabletop RPG Sessions"),
                            Description = "Test for last minute deals",
                            StartDate = DateTime.Parse("12/09/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/09/2018 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "NA", OrganizationContactInfo = "",
                            MaxTickets = 10, AvailableTickets = 10
                          },
                new Event { Title = "Last Minute Deal Test 02 Beta", EventType = eventTypes.Single(e => e.Type == "Rave"),
                            Description = "Test for last minute deals",
                            StartDate = DateTime.Parse("12/10/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/10/2018 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "NA", OrganizationContactInfo = "",
                            MaxTickets = 10, AvailableTickets = 10
                          },
                //events 11-15
                new Event { Title = "Last Minute Deal Test 03 boop", EventType = eventTypes.Single(e => e.Type == "Dance"),
                            Description = "Test for last minute deals",
                            StartDate = DateTime.Parse("12/11/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/11/2018 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "NA", OrganizationContactInfo = "",
                            MaxTickets = 10, AvailableTickets = 10
                          },
                new Event { Title = "Last Minute Deal Test 04 beep", EventType = eventTypes.Single(e => e.Type == "Concert"),
                            Description = "Test for last minute deals",
                            StartDate = DateTime.Parse("12/12/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/12/2018 9:30:00 PM"),
                            City = "Huston", State = "Texas",
                            OrganizationName = "NA", OrganizationContactInfo = "",
                            MaxTickets = 10, AvailableTickets = 10
                          },
                new Event { Title = "Last Minute Deal Test 05 blep", EventType = eventTypes.Single(e => e.Type == "FurMeet"),
                            Description = "Test for last minute deals",
                            StartDate = DateTime.Parse("12/13/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/13/2018 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "NA", OrganizationContactInfo = "",
                            MaxTickets = 10, AvailableTickets = 10
                          },
                new Event { Title = "Mad Hater Tea Party", EventType = eventTypes.Single(e => e.Type == "Tea Party"),
                            Description = "All fun and crazy tea",
                            StartDate = DateTime.Parse("12/18/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/18/2018 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Disney Madnesz", OrganizationContactInfo = "",
                            MaxTickets = 400, AvailableTickets = 270
                          },
                new Event { Title = "A Christmas Story", EventType = eventTypes.Single(e => e.Type == "Theatrical Play"),
                            Description = "",
                            StartDate = DateTime.Parse("12/8/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/23/2018 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "Playhouse Square", OrganizationContactInfo = "",
                            MaxTickets = 500, AvailableTickets = 200
                          },
                //events 16-20
                new Event { Title = "The Nutcracker", EventType = eventTypes.Single(e => e.Type == "Ballet"),
                            Description = "",
                            StartDate = DateTime.Parse("12/12/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/16/2018 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "Playhouse Square", OrganizationContactInfo = "",
                            MaxTickets = 700, AvailableTickets = 210
                          },
                new Event { Title = "Disney Dance Party", EventType = eventTypes.Single(e => e.Type == "Children's Event"),
                            Description = "",
                            StartDate = DateTime.Parse("12/15/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/15/2018 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Disney Channel", OrganizationContactInfo = "",
                            MaxTickets = 400, AvailableTickets = 110
                          },
                new Event { Title = "Wicked", EventType = eventTypes.Single(e => e.Type == "Musical"),
                            Description = "",
                            StartDate = DateTime.Parse("12/26/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("01/13/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Broadway", OrganizationContactInfo = "",
                            MaxTickets = 610, AvailableTickets = 110
                          },
                new Event { Title = "Calling All Mermaids", EventType = eventTypes.Single(e => e.Type == "Movie Night"),
                            Description = "",
                            StartDate = DateTime.Parse("12/15/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("12/15/2018 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Mother & Daughter Time", OrganizationContactInfo = "",
                            MaxTickets = 200, AvailableTickets = 100
                          },
                new Event { Title = "Doctor Who Madness", EventType = eventTypes.Single(e => e.Type == "Convention"),
                            Description = "",
                            StartDate = DateTime.Parse("01/11/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("01/13/2018 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "Whovian World", OrganizationContactInfo = "",
                            MaxTickets = 450, AvailableTickets = 200
                          },
                //events 21-25
                new Event { Title = "Old Guys & Classics", EventType = eventTypes.Single(e => e.Type == "Classic Car Show"),
                            Description = "",
                            StartDate = DateTime.Parse("01/20/2018 5:00:00 PM"),
                            EndDate = DateTime.Parse("01/24/2018 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Hotrods", OrganizationContactInfo = "",
                            MaxTickets = 400, AvailableTickets = 250
                          },
                new Event { Title = "Paw Patrol Dance Party", EventType = eventTypes.Single(e => e.Type == "Children's Event"),
                            Description = "",
                            StartDate = DateTime.Parse("03/08/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("03/10/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Nickelodeon", OrganizationContactInfo = "",
                            MaxTickets = 500, AvailableTickets = 350
                          },
                new Event { Title = "Off to Neverland", EventType = eventTypes.Single(e => e.Type == "Movie Night"),
                            Description = "",
                            StartDate = DateTime.Parse("02/06/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("02/06/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "LostBoys", OrganizationContactInfo = "",
                            MaxTickets = 200, AvailableTickets = 100
                          },
                new Event { Title = "World Friendship Day", EventType = eventTypes.Single(e => e.Type == "Gathering"),
                            Description = "",
                            StartDate = DateTime.Parse("01/26/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("01/26/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Girl Scout", OrganizationContactInfo = "",
                            MaxTickets = 500, AvailableTickets = 200
                          },
                new Event { Title = "Frankie Valli and the Four Seasons", EventType = eventTypes.Single(e => e.Type == "Concert"),
                            Description = "",
                            StartDate = DateTime.Parse("03/29/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("03/29/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "PLayhouse Square", OrganizationContactInfo = "",
                            MaxTickets = 700, AvailableTickets = 200
                          },
                //events 26-30
                new Event { Title = "Escape to Margaritaville", EventType = eventTypes.Single(e => e.Type == "Musical"),
                            Description = "",
                            StartDate = DateTime.Parse("03/15/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("07/01/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Broadway", OrganizationContactInfo = "",
                            MaxTickets = 700, AvailableTickets = 250
                          },
                new Event { Title = "The Phantom of the Opera", EventType = eventTypes.Single(e => e.Type == "Musical"),
                            Description = "",
                            StartDate = DateTime.Parse("04/03/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("04/20/2019 9:30:00 PM"),
                            City = "Cleveland", State = "Ohio",
                            OrganizationName = "PLayhouse Square", OrganizationContactInfo = "",
                            MaxTickets = 800, AvailableTickets = 250
                          },
                new Event { Title = "Mommies Shopping", EventType = eventTypes.Single(e => e.Type == "Resale"),
                            Description = "",
                            StartDate = DateTime.Parse("02/25/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("02/25/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Children Resale", OrganizationContactInfo = "",
                            MaxTickets = 500, AvailableTickets = 200
                          },
                new Event { Title = "Minnies Bows Tea Party", EventType = eventTypes.Single(e => e.Type == "Tea Party"),
                            Description = "",
                            StartDate = DateTime.Parse("04/14/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("04/14/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Dinsey Minnie Mouse", OrganizationContactInfo = "",
                            MaxTickets = 500, AvailableTickets = 250
                          },
                new Event { Title = "Face Off", EventType = eventTypes.Single(e => e.Type == "Movie Magic"),
                            Description = "",
                            StartDate = DateTime.Parse("04/26/2019 5:00:00 PM"),
                            EndDate = DateTime.Parse("04/29/2019 9:30:00 PM"),
                            City = "Parma", State = "Ohio",
                            OrganizationName = "Syfy Movie Artists", OrganizationContactInfo = "",
                            MaxTickets = 600, AvailableTickets = 250
                          },

            }.ForEach(e => context.Events.Add(e));

            base.Seed(context);
        }
    }
}