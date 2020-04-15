using System.ComponentModel;

namespace SacramentMeetingPlanner.Models
{
    public enum ParticipantRoles
    {
        [Description("{Presiding")]
        PresidingLeader,

        [Description("Conducting")]
        ConductingLeader,

        [Description("Opening Prayer")]
        OpeningPrayer,

        Speaker,

        [Description("Closing Prayer")]
        ClosingPrayer
    }
}
