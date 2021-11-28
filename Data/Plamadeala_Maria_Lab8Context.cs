using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Plamadeala_Maria_Lab8.Models;

namespace Plamadeala_Maria_Lab8.Data
{
    public class Plamadeala_Maria_Lab8Context : DbContext
    {
        public Plamadeala_Maria_Lab8Context (DbContextOptions<Plamadeala_Maria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Plamadeala_Maria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Plamadeala_Maria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Plamadeala_Maria_Lab8.Models.Category> Category { get; set; }
    }
}
