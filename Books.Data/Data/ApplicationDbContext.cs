using Books.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Data.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<TYT> TYT { get; set; }
        public DbSet<AYT> AYT { get; set; }
        public DbSet<EXAM> EXAM { get; set; }
    }
}
