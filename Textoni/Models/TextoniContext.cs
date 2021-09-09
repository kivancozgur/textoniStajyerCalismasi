using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Textoni.Models.Entity;

namespace Textoni.Models
{
    public class TextoniContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-SFIE3IR;database=AdvertDB;trusted_connection=true;");
        }

        public DbSet<Advert> Ad{ get; set; }
        public DbSet<CreateAd> CreateAdvert { get; set; }
    }
}
