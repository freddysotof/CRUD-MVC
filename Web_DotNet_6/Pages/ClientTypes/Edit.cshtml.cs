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

namespace Web_DotNet_6.Pages.ClientTypes
{
    public class EditModel : PageModel
    {
        private readonly BO_DotNet_6.Context.TestingContext _context;

        public EditModel(BO_DotNet_6.Context.TestingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ClientType ClientType { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ClientType == null)
            {
                return NotFound();
            }

            var clienttype =  await _context.ClientType.FirstOrDefaultAsync(m => m.Id == id);
            if (clienttype == null)
            {
                return NotFound();
            }
            ClientType = clienttype;
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

            _context.Attach(ClientType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientTypeExists(ClientType.Id))
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

        private bool ClientTypeExists(int id)
        {
          return _context.ClientType.Any(e => e.Id == id);
        }
    }
}
