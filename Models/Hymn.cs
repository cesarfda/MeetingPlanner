using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetingPlanner.Models
{
    public class Hymn
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }

        public string HymnName
        {
            get
            {
                return Number.ToString() + " - " + Title;
            }
        }
    }
}