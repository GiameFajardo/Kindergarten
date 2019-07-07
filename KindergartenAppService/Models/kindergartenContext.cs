using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KindergartenAppService.Models;

namespace KindergartenAppService.Models
{
    public class KindergartenContext:DbContext
    {
        public KindergartenContext(DbContextOptions<KindergartenContext> options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //MAny to many relationship betwen Feedings and kids
            modelBuilder.Entity<FeedingKid>()
                .HasKey(fk => new { fk.KidId, fk.FeddingId });
            modelBuilder.Entity<FeedingKid>()
                .HasOne(fk => fk.Fedding)
                .WithMany(k => k.FeedingKids)
                .HasForeignKey(fk => fk.FeddingId);
            modelBuilder.Entity<FeedingKid>()
                .HasOne(fk => fk.Kid)
                .WithMany(f => f.FeedingKids)
                .HasForeignKey(fk => fk.KidId);
            //Abstraction for Item
            modelBuilder.Entity<Product>();
            modelBuilder.Entity<Service>();
            //Many to many relationship betwen Product and store
            modelBuilder.Entity<Stock>()
                .HasKey(sk => new { sk.StoreId, sk.ProductId});
            modelBuilder.Entity<Stock>()
                .HasOne(sk => sk.Product)
                .WithMany(st => st.Stock)
                .HasForeignKey(sk => sk.ProductId);
            modelBuilder.Entity<Stock>()
                .HasOne(sk => sk.Store)
                .WithMany(p => p.Stock)
                .HasForeignKey(sk => sk.StoreId);
            //
            //modelBuilder.Entity<Kid>()
            //    .HasKey(k => k.TutorId);
            //modelBuilder.Entity<Kid>()
            //    .HasOne(t=>t.Tutor)
            //    .WithOne(k=>k.)
        }
        public DbSet<Kindergarter> Kindergarters { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<KindergartenAppService.Models.Activity> Activity { get; set; }
    }
}
