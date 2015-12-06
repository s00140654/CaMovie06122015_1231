using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using CaMovie.Models;

namespace CaMovie.DAL
{
    public class MovieContext:DbContext
    {
        public MovieContext() : base("MovieContext")
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Casting> Castings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   //prevents table names from being pluralized (optional
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}