using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KindergartenAppService.Models
{
    public class KindergarterContext : IdentityDbContext<ApplicationUser>
    {
        public KindergarterContext(DbContextOptions<KindergarterContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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
            //One to one relationship between Kid and Enrollment
            //modelBuilder.Entity<Kid>()
            //    .HasOne(p => p.Enrollment)
            //    .WithOne(i => i.Kid)
            //    .HasForeignKey<Enrollment>(e=>e.Kid);
            //Multiple independent Tutors in Kid
            modelBuilder.Entity<Kid>()
                .HasOne(k => k.TutorPrincipal)
                .WithMany()
                .HasForeignKey(k => k.TutorPrincipalId);
            modelBuilder.Entity<Kid>()
                .HasOne(k => k.TutorAutorized)
                .WithMany()
                .HasForeignKey(k => k.TutorAutorizedId);
            modelBuilder.Entity<Kid>()
                .HasOne(k => k.TutorSecundary)
                .WithMany()
                .HasForeignKey(k => k.TutorSecundaryId);
            //Reference Service to EnrollActivity handeling
            //cycles or multiple cascade paths
            modelBuilder.Entity<EnrollActivity>()
                .HasOne(e => e.Service)
                .WithMany(s => s.EnrollActivities)
                .HasForeignKey(e => e.ServiceId)
                .OnDelete(DeleteBehavior.Restrict);
            //Configuration for Invoice and details
            modelBuilder.Entity<InvoiceDetail>()
                .HasOne(d => d.Invoice)
                .WithMany(i => i.InvoiceDetails)
                .HasForeignKey(d => d.InvoiceId)
                .OnDelete(DeleteBehavior.Restrict);
            
                
            #endregion
            /*
            #region Seeding
            //Kindergarter
            var kindergarter = new Kindergarter
            {
                Id = Guid.NewGuid(),
                Description = "KPH"
            };
            var activitiesTemplates = GenerateActivityTemplates(kindergarter);
            //Activities
            var activities = GenerateActivities(activitiesTemplates);
            //Services
            var services = GenerateServices(activities);
            //Tutor
            var tutors = GenerateTutors();
            //Pediatrician
            var pediatrician = GeneratePediatrician();
            //Kids
            var kids = GenerateRandonKids(kindergarter, tutors, 10);
            //Enrollment
            var enrollments = GenerateEnrollments(kids.Take(5).ToList());
            //Activity enroll
            var enrollActivities = GenerateEnrollActivities(enrollments, activities);

            //modelBuilder.Entity<Kindergarter>().HasData(kindergarter);
            //modelBuilder.Entity<ActivityTemplate>().HasData(activitiesTemplates);
            //modelBuilder.Entity<Activity>().HasData(activities);
            //modelBuilder.Entity<Service>().HasData(services);
            //modelBuilder.Entity<Tutor>().HasData(tutors);
            //modelBuilder.Entity<Pediatrician>().HasData(pediatrician);
            //modelBuilder.Entity<Kid>().HasData(kids);
            //modelBuilder.Entity<Enrollment>().HasData(enrollments);
            //modelBuilder.Entity<EnrollActivity>().HasData(enrollActivities);
            #endregion
            */
        }
        

        private List<EnrollActivity> GenerateEnrollActivities(List<Enrollment> enrollments, List<Activity> activities)
        {
            List<EnrollActivity> enrollActivities = new List<EnrollActivity>();
            int activitiesCount = activities.Count();
            Random random = new Random();

            foreach (var enrollment in enrollments)
            {
                enrollActivities.Add(new Models.EnrollActivity
                {
                    Id = Guid.NewGuid(),
                    ActivityId = activities[random.Next(activitiesCount)].Id,
                    EnrollmentId = enrollment.Id

                });

            }

            return enrollActivities;
        }

        public DbSet<Kindergarter> Kindergarters { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public DbSet<KindergartenAppService.Models.Activity> Activity { get; set; }
        public DbSet<KindergartenAppService.Models.Pediatrician> Pediatrician { get; set; }
        public DbSet<KindergartenAppService.Models.Kid> Kid { get; set; }
        public DbSet<KindergartenAppService.Models.Item> Item { get; set; }
        public DbSet<KindergartenAppService.Models.Product> Product { get; set; }
        public DbSet<KindergartenAppService.Models.Service> Service { get; set; }
        public DbSet<KindergartenAppService.Models.ActivityTemplate> ActivityTemplate { get; set; }
        public DbSet<KindergartenAppService.Models.EnrollActivity> EnrollActivity { get; set; }
        public DbSet<Sequence> Sequences { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Receipt> Receipt { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }

        #region Seeding Methods
        private List<Enrollment> GenerateEnrollments(List<Kid> kids)
        {
            List<Enrollment> enrollments = new List<Enrollment>();

            foreach (var kid in kids)
            {
                enrollments.Add(new Enrollment
                {
                    Id = Guid.NewGuid(),
                    EnrollDay = new DateTime(2019, 7, 28),
                    KidId = kid.Id
                });
            }
            return enrollments;
        }
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

            int count = tutors.Count - 1;

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
                               TutorPrincipalId = tutors[rnd.Next(count)].Id
                           };
            return kidsList.OrderBy(k => k.Id).Take(quantity).ToList();
        }
        private List<Kid> GenerateRandonKids(Kindergarter kindergarter, List<Tutor> tutors, Pediatrician pediatrician, int quantity)
        {
            List<Kid> kids = new List<Kid>();
            string[] firstName = { "Johan", "Lyan", "Dylan", "Aaron" };
            string[] secondName = { "Carlos", "Eduardo", "Enrique", "Emilio" };
            string[] fatherName = { "Faringtom", "Escobar", "Lee", "Stackeetam" };
            string[] motherName = { "Washinton", "White", "Worm", "Snow" };
            Random rnd = new Random();

            int count = tutors.Count - 1;

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
                               TutorPrincipalId = tutors[rnd.Next(count)].Id,
                               //PediatricianId = pediatrician.Id
                           };
            return kidsList.OrderBy(k => k.Id).Take(quantity).ToList();
        }

        private List<Service> GenerateServices(List<Activity> activities)
        {
            List<Service> services = new List<Service>();
            Random random = new Random();
            foreach (Activity activity in activities)
            {

                services.Add(new Models.Service
                {
                    Id = Guid.NewGuid(),
                    ActivityId = activity.Id,
                    Description = "Service " + activity.Description,
                    Reference = "SRV-" + random.Next(1000).ToString(),
                    Price = random.Next(10000),
                    ServicePeriod = ServicePeriod.Monthly
                });
            }

            return services;
        }

        private List<Activity> GenerateActivities(List<ActivityTemplate> activityTemplates)
        {
            List<Activity> activities = new List<Activity>();
            foreach (ActivityTemplate template in activityTemplates)
            {
                activities.Add(new Models.Activity
                {
                    Id = Guid.NewGuid(),
                    Description = template.Description,
                    ActivityTemplateId = template.Id
                });
            }
            return activities;
        }
        private List<ActivityTemplate> GenerateActivityTemplates(Kindergarter kindergarter)
        {
            List<ActivityTemplate> activitytemplates = new List<ActivityTemplate>();
            activitytemplates.AddRange(
                new List<ActivityTemplate>
                {
                    new ActivityTemplate{Id = Guid.NewGuid(), Description = "Clases de ingles", KindergarterId = kindergarter.Id},
                    new ActivityTemplate{Id = Guid.NewGuid(), Description = "Cuidade matutino", KindergarterId = kindergarter.Id},
                    new ActivityTemplate{Id = Guid.NewGuid(), Description = "Cuidado Vespertino", KindergarterId = kindergarter.Id},
                    new ActivityTemplate{Id = Guid.NewGuid(), Description = "Cuidado dia completo", KindergarterId = kindergarter.Id},
                    new ActivityTemplate{Id = Guid.NewGuid(), Description = "Clases de Ballet", KindergarterId = kindergarter.Id},
                    new ActivityTemplate{Id = Guid.NewGuid(), Description = "Clases de logica", KindergarterId = kindergarter.Id}
                }
            );
            return activitytemplates;
        }
        private Pediatrician GeneratePediatrician()
        {
            Pediatrician pediatrician = new Pediatrician
            {
                Id = Guid.NewGuid(),
                Name = "Felipe Felix",
                Address = "Address",
                PhoneNumber = "809-852-8521"
            };
            return pediatrician;
        }
        private Pediatrician GeneratePediatrician(List<Kid> kids)
        {
            Pediatrician pediatrician = new Pediatrician
            {
                Id = Guid.NewGuid(),
                Name = "Felipe Felix",
                Address = "Address",
                PhoneNumber = "809-852-8521"
            };
            if (kids.Count > 0)
            {
                foreach (Kid kid in kids)
                {
                    pediatrician.Kids.Add(kid);
                }

            }
            return pediatrician;
        }
        #endregion
    }
}
