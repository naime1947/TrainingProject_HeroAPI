using System;
using Microsoft.EntityFrameworkCore;
using HeroAPI.Models;

namespace HeroAPI.Models{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        DbSet<Hero> Heros {get;set;}
    }
}