﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BO_DotNet_6.Context;
using BO_DotNet_6.Models.Entities;

namespace Web_DotNet_6.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly BO_DotNet_6.Context.TestingContext _context;

        public IndexModel(BO_DotNet_6.Context.TestingContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.User != null)
            {
                User = await _context.User
                .Include(u => u.People).ToListAsync();
            }
        }
    }
}
