﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BO_DotNet_6.Context;
using BO_DotNet_6.Models.Entities;

namespace Web_DotNet_6.Pages.Departments
{
    public class EditModel : PageModel
    {
        private readonly BO_DotNet_6.Context.TestingContext _context;

        public EditModel(BO_DotNet_6.Context.TestingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Deparment Deparment { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Deparment == null)
            {
                return NotFound();
            }

            var deparment =  await _context.Deparment.FirstOrDefaultAsync(m => m.Id == id);
            if (deparment == null)
            {
                return NotFound();
            }
            Deparment = deparment;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Deparment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeparmentExists(Deparment.Id))
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

        private bool DeparmentExists(int id)
        {
          return _context.Deparment.Any(e => e.Id == id);
        }
    }
}
