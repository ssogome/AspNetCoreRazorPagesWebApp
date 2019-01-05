﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCoreRazorPagesWebApp.Models;

namespace AspNetCoreRazorPagesWebApp.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly AspNetCoreRazorPagesWebApp.Models.CustomerContext _context;

        public DetailsModel(AspNetCoreRazorPagesWebApp.Models.CustomerContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.Id == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
