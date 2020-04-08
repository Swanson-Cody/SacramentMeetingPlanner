using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public enum ParticipantRoles
    {
        [Description("{Presiding")]
        PresidingLeader,

        [Description("Conducting")]
        ConductingLeader,

        Speaker,

        [Description("Opening Prayer")]
        OpeningPrayer,

        [Description("Closing Prayer")]
        ClosingPrayer
    }
}
