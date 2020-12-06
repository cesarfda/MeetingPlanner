using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MeetingPlanner.Models
{
    public class Leader
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}