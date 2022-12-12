using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Footballers3.Data;
using Footballers3.Models;
using Microsoft.EntityFrameworkCore;

namespace Footballers3.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Footballers3.Data.Footballers3Context _context;

        public CreateModel(Footballers3.Data.Footballers3Context context)
        {
            _context = context;
        }

        //public IActionResult OnGet()
        //{
        //    return Page();
        //}

        public IList<Footballer> Footballers { get; set; } = default!;

       

        [BindProperty]
        public Footballer Footballer { get; set; } = default!;

        


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Footballer == null || Footballer == null)
            {
                return Page();
            }

            _context.Footballer.Add(Footballer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        public async Task OnGetAsync()
        {
            if (_context.Footballer != null)
            {
                Footballers = await _context.Footballer.ToListAsync();
            }
        }




    }
}
