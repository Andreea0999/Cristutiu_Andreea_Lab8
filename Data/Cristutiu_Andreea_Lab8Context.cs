using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cristutiu_Andreea_Lab8.Models;

namespace Cristutiu_Andreea_Lab8.Data
{
    public class Cristutiu_Andreea_Lab8Context : DbContext
    {
        public Cristutiu_Andreea_Lab8Context (DbContextOptions<Cristutiu_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cristutiu_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cristutiu_Andreea_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cristutiu_Andreea_Lab8.Models.Category> Category { get; set; }
    }
}
