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

        [Display(Name = "Conductor")]
        public string ConductingLeader { get; set; }

        [Display(Name = "Opening Song")]
        public string OpeningSong { get; set; }

        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        public List<Speaker> Speakers { get; set; }

        [Display(Name = "Intermediate Music")]
        public string IntermediateMusic { get; set; }
        
        [Display(Name = "Closing Song")]
        public string ClosingSong { get; set; }

        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }
    }
}
