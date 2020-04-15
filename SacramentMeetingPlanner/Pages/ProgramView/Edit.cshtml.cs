using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.Program
{
    public class EditModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;

        public EditModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Program Program { get; set; }

        [BindProperty]
        public List<Participant> Participants { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Program = await _context.Program.FirstOrDefaultAsync(m => m.ProgramID == id);
            Participants = await _context.Participant.Where(x => x.ProgramID == Program.ProgramID).ToListAsync();

            if (Program == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostSaveProgramAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _context.Attach(Program).State = EntityState.Modified;
                //_context.Program.Update(Program);
                await _context.SaveChangesAsync();

                foreach (var participant in Program.Participants)
                {
                    _context.Attach(participant).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramExists(Program.ProgramID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        public async Task OnPostAddParticipantAsync()
        {
            Participants.Add(new Participant());
        }

        private bool ProgramExists(int id)
        {
            return _context.Program.Any(e => e.ProgramID == id);
        }

        public async Task OnPostRemoveParticipantAsync(int index)
        {
            Participants.RemoveAt(index);
            ModelState.Clear();
        }
    }
}
