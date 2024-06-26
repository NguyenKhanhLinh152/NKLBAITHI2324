using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NKLBAITHI2324.Models;

namespace NKLBAITHI2324.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<NKL391Person> NKL391Persons { get; set; }
        public DbSet<NKL391Employee> NKL391Employees { get; set; }
    }
}