using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week6_ClassTest.Models
{
    public class NoviceContext:DbContext
    {

        public NoviceContext():base("Novice")
        { }
        public DbSet<Novice> Novices { get; set; }
        public DbSet<NoviceDetail> NoviceDetails { get; set; }

        public DbSet<ViewModel> ViewModels { get; set; }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Wed");

            // Configure NoviceId as PK for NoviceDetail
            modelBuilder.Entity<NoviceDetail>()
                .HasKey(e => e.NoviceId);

            // Configure NoviceId as FK for NoviceDetail
            modelBuilder.Entity<Novice>()
                        .HasRequired(s => s.NoviceDetail)
                        .WithRequiredPrincipal(ad => ad.Novice);

        }
    }
}