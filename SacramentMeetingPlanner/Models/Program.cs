using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Program
    {
        public int ProgramID { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime DateOfMeeting { get; set; }

        //[Display(Name = "Presiding")]
        //public Participant PresidingLeader { get; set; }

        //[Display(Name = "Conductor")]
        //public Participant ConductingLeader { get; set; }

        [Display(Name = "Opening Song")]
        public string OpeningSong { get; set; }

        //[Display(Name = "Opening Prayer")]
        //public Participant OpeningPrayer { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        public List<Participant> Participants { get; set; }

        [Display(Name = "Intermediate Music")]
        public string IntermediateMusic { get; set; }

        [Display(Name = "Closing Song")]
        public string ClosingSong { get; set; }

        //[Display(Name = "Closing Prayer")]
        //public Participant ClosingPrayer { get; set; }
    }
}
