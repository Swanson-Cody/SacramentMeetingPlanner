using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Participant
    {
        //primary key
        public int ParticipantID { get; set; }

        [Display(Name = "Full Name")]
        public string FullNameOfParticipant { get; set; }

        public string TalkSubject { get; set; }

        public string ParticipantTitle { get; set; }

        public string ParticipantRole { get; set; }

        public int ProgramID { get; set; }

    }
}
