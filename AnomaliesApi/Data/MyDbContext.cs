using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using AnomaliesApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnomaliesApi.Data

{
    public class MyDbContext : DbContext
    {
        public MyDbContext([NotNullAttribute] DbContextOptions<MyDbContext> options) : base(options)
        {


        }



        protected override void OnModelCreating(ModelBuilder builder)
        {


            // builder.Entity<User>().HasKey(x => x.id).;

            base.OnModelCreating(builder);

        }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Ressource> Ressources { get; set; }




    }
}