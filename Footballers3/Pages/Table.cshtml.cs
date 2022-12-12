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
    public class TableModel : PageModel
    {
        private readonly Footballers3.Data.Footballers3Context _context;

        public TableModel(Footballers3.Data.Footballers3Context context)
        {
            _context = context;
        }

        public IList<Footballer> Footballer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Footballer != null)
            {
                Footballer = await _context.Footballer.ToListAsync();
            }
        }
    }
}
