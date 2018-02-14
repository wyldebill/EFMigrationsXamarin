using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App11
{
    //test
    public class myContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        private string DatabasePath { get; set; }
        public myContext()
        {

        }

        public myContext(string databasePath)
        {
            DatabasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }
    }
}
