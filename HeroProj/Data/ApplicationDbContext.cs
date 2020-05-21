using System;
using System.Collections.Generic;
using System.Text;
using HeroProj.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HeroProj.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
         public DbSet<Superhero> Superheros{ get; set; }
    }

}
