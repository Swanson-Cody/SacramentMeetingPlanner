using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.Program
{
    public class DetailsModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public DetailsModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        public Models.Program Program { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Program = await _context.Program.FirstOrDefaultAsync(m => m.ProgramID == id);

            if (Program == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
