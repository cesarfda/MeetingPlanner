using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetingPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }


        [Display(Name = "Conducting Leader")]
        public string LeaderName { get; set; }


        [Display(Name = "Opening Hymn")]
        public int OpeningHymnId { get; set; }


        [Display(Name = "Sacrament Hymn")]
        public int SacramentHymnId { get; set; }


        [Display(Name = "Closing Hymn")]
        public int ClosingHymnId { get; set; }

        [Display(Name = "Intermediate Hymn")]
        public int IntermediateHymnId { get; set; }


        [Display(Name = "Opening Prayer")]
        [StringLength(100)]
        public string OpeningPrayer { get; set; }


        [Display(Name = "Closing Prayer")]
        [StringLength(100)]
        public string ClosingPrayer { get; set; }

        public List<Subject> SpeakerSubjects { get; set; }
    }
}