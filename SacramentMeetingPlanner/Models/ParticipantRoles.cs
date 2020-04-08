using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public enum ParticipantRoles
    {
        [Display(Name = "Presiding")]
        PresidingLeader,

        [Display(Name = "Conductor")]
        ConductingLeader,

        Speaker,

        [Display(Name = "Opening Prayer")]
        OpeningPrayer,

        [Display(Name = "Closing Prayer")]
        ClosingPrayer
    }
}
