﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Pages.Program
{
    public class CreateModel : PageModel
    {
        private readonly SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext _context;
        
        [BindProperty]
        public List<Participant> Participants { get; set; }

        public CreateModel(SacramentMeetingPlanner.Data.SacramentMeetingPlannerContext context)
        {
            _context = context;
            Program = new Models.Program
            {
                DateOfMeeting = DateTime.Now, 
                Participants = new List<Participant>
                {
                    new Participant(), 
                    new Participant(), 
                    new Participant(), 
                    new Participant(), 
                    new Participant
                    {
                        ParticipantRole = ParticipantRoles.Speaker.ToString()
                    }
                }
            };
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Program Program { get; set; }

        public async Task OnPostAddParticipantAsync()
        {
            Program.Participants.Add(new Participant{ ParticipantRole = ParticipantRoles.Speaker.ToString() });
        }

        public async Task OnPostRemoveParticipantAsync(int index)
        {
            Program.Participants.RemoveAt(index);
            ModelState.Clear();
        }

        public async Task<IActionResult> OnPostSaveProgramAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Program.Add(Program);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
