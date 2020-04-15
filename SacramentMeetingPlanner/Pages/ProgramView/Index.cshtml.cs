using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace SacramentMeetingPlanner.Pages.Program
{
    public class IndexModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public IndexModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public IList<Models.Program> Program { get;set; }
        public IList<Models.Participant> Speakers { get; set; }

        public async Task OnGetAsync()
        {
            Program = await _context.Program.ToListAsync();
            Speakers = await _context.Participant.ToListAsync();
        }
    }
}
