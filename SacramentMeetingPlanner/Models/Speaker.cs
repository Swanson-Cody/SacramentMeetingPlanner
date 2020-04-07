using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        //primary key
        public int SpeakerID { get; set; }
        
        //foreign key
        public int ProgramId { get; set; }

        [Display(Name = "First name of speaker")]
        public string SpeakerFirstName { get; set; }

        [Display(Name = "Last name of speaker")]
        public string SpeakerLastName { get; set; }

        public string TalkSubject { get; set; }
    }
}
