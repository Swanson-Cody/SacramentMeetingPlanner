using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.Program
{
    public class CreateModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;
        
        [BindProperty]
        public List<Speaker> Speakers { get; set; }

        public CreateModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
            Speakers = new List<Speaker> { new Speaker() };
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Program Program { get; set; }

        public async Task OnPostAddSpeakerAsync()
        {
            Speakers.Add(new Speaker());
        }

        public async Task OnPostRemoveSpeakerAsync(int index)
        {
            Speakers.RemoveAt(index);
            ModelState.Clear();
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostSaveProgramAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Program.Add(Program);
            await _context.SaveChangesAsync();

            foreach (var speakers in Speakers)
            {
                speakers.ProgramId = Program.ProgramID;
                _context.Speaker.Add(speakers);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
