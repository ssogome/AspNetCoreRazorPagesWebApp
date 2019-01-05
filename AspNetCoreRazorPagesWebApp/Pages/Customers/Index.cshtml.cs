using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCoreRazorPagesWebApp.Models;

namespace AspNetCoreRazorPagesWebApp.Pages.Customers
{
    public class IndexModel : PageModel
    {       
        private readonly AspNetCoreRazorPagesWebApp.Models.CustomerContext _context;

        public IndexModel(AspNetCoreRazorPagesWebApp.Models.CustomerContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
