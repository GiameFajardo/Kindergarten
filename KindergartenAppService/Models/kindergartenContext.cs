﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KindergartenAppService.Models
{
    public class KindergarterContext : DbContext
    {
        public KindergarterContext(DbContextOptions<KindergarterContext> options) : base(options)
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
                .HasKey(sk => new { sk.StoreId, sk.ProductId });
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
            //Kindergarter
            var kindergarter = new Kindergarter
            {
                Id = Guid.NewGuid(),
                Description = "Guarderia"
            };
            //Tutor
            var tutors = GenerateTutors();
            //Kids
            var kids = GenerateRandonKids(kindergarter, tutors, 10);


            modelBuilder.Entity<Kindergarter>().HasData(kindergarter);
            modelBuilder.Entity<Tutor>().HasData(tutors);
            modelBuilder.Entity<Kid>().HasData(kids);
            #endregion
        }


        public DbSet<Kindergarter> Kindergarters { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<KindergartenAppService.Models.Activity> Activity { get; set; }
        public DbSet<KindergartenAppService.Models.Kid> Kid { get; set; }
        public DbSet<KindergartenAppService.Models.Item> Item { get; set; }
        public DbSet<KindergartenAppService.Models.Product> Product { get; set; }
        public DbSet<KindergartenAppService.Models.Service> Service { get; set; }

        #region Seeding Methods
        private List<Tutor> GenerateTutors()
        {
            return new List<Tutor>
            {
                new Tutor{FirstName = "Gregorio de Jesus", LastName = "Rojas Acosta", Id = Guid.NewGuid()},
                new Tutor{FirstName = "Yadira",LastName = "Pinales Delgado", Id = Guid.NewGuid()}
            };
        }
        private List<Kid> GenerateRandonKids(Kindergarter kindergarter, List<Tutor> tutors, int quantity)
        {
            List<Kid> kids = new List<Kid>();
            string[] firstName = { "Johan", "Lyan", "Dylan", "Aaron" };
            string[] secondName = { "Carlos", "Eduardo", "Enrique", "Emilio" };
            string[] fatherName = { "Faringtom", "Escobar", "Lee", "Stackeetam" };
            string[] motherName = { "Washinton", "White", "Worm", "Snow" };
            Random rnd = new Random();

            int count = tutors.Count-1;

            var kidsList = from fn in firstName
                           from sn in secondName
                           from an in fatherName
                           from mn in motherName
                           select new Kid
                           {
                               Id = Guid.NewGuid(),
                               FirstName = fn,
                               SecondName = sn,
                               FatherName = an,
                               MotherName = mn,
                               KindergarterId = kindergarter.Id,
                               TutorId = tutors[rnd.Next(count)].Id
                           };
            return kidsList.OrderBy(k => k.Id).Take(quantity).ToList();
        }
        #endregion
    }
}
