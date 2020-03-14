using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>()
        //        .Property(x => x.Name)
        //        .HasMaxLength(255)
        //        .IsRequired()
        //        .HasColumnName("Name");

        //    modelBuilder.Entity<Student>()
        //        .Property(x => x.Surename)
        //        .HasMaxLength(255)
        //        .IsRequired()
        //        .HasColumnName("Surename");
        //}
    }
}