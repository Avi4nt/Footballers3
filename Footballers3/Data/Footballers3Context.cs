using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Footballers3.Models;

namespace Footballers3.Data
{
    public class Footballers3Context : DbContext
    {
        public Footballers3Context (DbContextOptions<Footballers3Context> options)
            : base(options)
        {
        }

        public DbSet<Footballers3.Models.Footballer> Footballer { get; set; } = default!;
    }
}
