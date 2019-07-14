using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KindergartenAppService.Models;

namespace KindergartenAppService.Models
{
    public class KindergarterContext:DbContext
    {
        public KindergarterContext(DbContextOptions<KindergarterContext> options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Relationships

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
            //Many to many relationship between Invoice and Receipt
            modelBuilder.Entity<Payment>()
                .HasKey(p => new { p.InvoiceId, p.ReceiptId });
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Invoice)
                .WithMany(r => r.Payments)
                .HasForeignKey(p => p.InvoiceId);
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Receipt)
                .WithMany(i => i.Payments)
                .HasForeignKey(p => p.ReceiptId);
            #endregion
            #region Seeding
            modelBuilder.Entity<Kindergarter>().HasData(
                new Kindergarter
                {
                    Description = "Guarderia"
                }
                );
            #endregion
        }
        public DbSet<Kindergarter> Kindergarters { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<KindergartenAppService.Models.Activity> Activity { get; set; }
        public DbSet<KindergartenAppService.Models.Kid> Kid { get; set; }
        public DbSet<KindergartenAppService.Models.Item> Item { get; set; }
        public DbSet<KindergartenAppService.Models.Product> Product { get; set; }
        public DbSet<KindergartenAppService.Models.Service> Service { get; set; }
    }
}
