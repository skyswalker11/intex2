using System;
using Microsoft.EntityFrameworkCore;

namespace intexnew.Models
{
    public class CrashesDbContext : DbContext
    {
        //constructor
        public CrashesDbContext(DbContextOptions<CrashesDbContext> options) : base (options)
        {

        }

        public DbSet<Crash> Crashes { get; set; }


    }

}
