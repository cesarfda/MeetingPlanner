using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MeetingPlanner.Models
{
    public class Subject
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string SpeakerName { get; set; }

        [StringLength(200)]
        public string SubjectTitle { get; set; }
    }
}