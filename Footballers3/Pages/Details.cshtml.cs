using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Footballers3.Data;
using Footballers3.Models;

namespace Footballers3.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Footballers3.Data.Footballers3Context _context;

        public DetailsModel(Footballers3.Data.Footballers3Context context)
        {
            _context = context;
        }

      public Footballer Footballer { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Footballer == null)
            {
                return NotFound();
            }

            var footballer = await _context.Footballer.FirstOrDefaultAsync(m => m.ID == id);
            if (footballer == null)
            {
                return NotFound();
            }
            else 
            {
                Footballer = footballer;
            }
            return Page();
        }
    }
}
