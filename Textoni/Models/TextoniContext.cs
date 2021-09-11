﻿using Microsoft.EntityFrameworkCore;
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
        

        public DbSet<Adverts> AdvertTable { get; set; }
        public DbSet<AdvertTypes> AdType { get; set; }
        public DbSet<Language>  AdLanguage{ get; set; }
        public DbSet<SourceLanguage> AdSourceLanguage { get; set; }
        public DbSet<Categorie> AdCategorie { get; set; }
    }
}
