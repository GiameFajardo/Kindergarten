﻿// <auto-generated />
using System;
using KindergartenAppService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KindergartenAppService.Migrations
{
    [DbContext(typeof(KindergarterContext))]
    [Migration("20190720154332_Fields_added_to_service_and_Item")]
    partial class Fields_added_to_service_and_Item
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KindergartenAppService.Models.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<Guid>("KindergarterId");

                    b.HasKey("Id");

                    b.HasIndex("KindergarterId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("KindergartenAppService.Models.EnrollActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ActivityId");

                    b.Property<Guid?>("EnrollmentId");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("EnrollmentId");

                    b.ToTable("EnrollActivity");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Enrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EnrollDay");

                    b.Property<Guid>("KidId");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Feeding", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Feeding");
                });

            modelBuilder.Entity("KindergartenAppService.Models.FeedingKid", b =>
                {
                    b.Property<Guid>("KidId");

                    b.Property<Guid>("FeddingId");

                    b.HasKey("KidId", "FeddingId");

                    b.HasIndex("FeddingId");

                    b.ToTable("FeedingKid");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<Guid>("KidId");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("KindergartenAppService.Models.InvoiceDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<Guid?>("InvoiceId");

                    b.Property<Guid>("ItemId");

                    b.Property<decimal>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ItemId");

                    b.ToTable("InvoiceDetail");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<string>("Reference");

                    b.HasKey("Id");

                    b.ToTable("Item");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Item");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Kid", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FatherName")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<Guid>("KindergarterId");

                    b.Property<string>("MotherName");

                    b.Property<string>("SecondName");

                    b.Property<Guid>("TutorId");

                    b.HasKey("Id");

                    b.HasIndex("KindergarterId");

                    b.HasIndex("TutorId");

                    b.ToTable("Kid");

                    b.HasData(
                        new
                        {
                            Id = new Guid("017db7ca-deee-4412-884b-d4b46fc372e7"),
                            FatherName = "Escobar",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"),
                            MotherName = "Washinton",
                            SecondName = "Enrique",
                            TutorId = new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d")
                        },
                        new
                        {
                            Id = new Guid("02e2617d-e74d-4ef4-a13e-deca76d10bc8"),
                            FatherName = "Faringtom",
                            FirstName = "Johan",
                            KindergarterId = new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"),
                            MotherName = "Snow",
                            SecondName = "Enrique",
                            TutorId = new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d")
                        },
                        new
                        {
                            Id = new Guid("0379cc56-36d8-4316-98fb-ef9e9edfab35"),
                            FatherName = "Faringtom",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"),
                            MotherName = "Worm",
                            SecondName = "Carlos",
                            TutorId = new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d")
                        },
                        new
                        {
                            Id = new Guid("03c9df9a-d484-45f0-b858-fbe75520b320"),
                            FatherName = "Faringtom",
                            FirstName = "Aaron",
                            KindergarterId = new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"),
                            MotherName = "Snow",
                            SecondName = "Enrique",
                            TutorId = new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d")
                        },
                        new
                        {
                            Id = new Guid("03ec5db0-fe1f-4503-be6e-e8d8dc27449c"),
                            FatherName = "Faringtom",
                            FirstName = "Johan",
                            KindergarterId = new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"),
                            MotherName = "Washinton",
                            SecondName = "Carlos",
                            TutorId = new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d")
                        },
                        new
                        {
                            Id = new Guid("049349af-fc53-41b4-90d8-947bfcc38fd1"),
                            FatherName = "Faringtom",
                            FirstName = "Johan",
                            KindergarterId = new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"),
                            MotherName = "White",
                            SecondName = "Emilio",
                            TutorId = new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d")
                        },
                        new
                        {
                            Id = new Guid("04fb0a57-8134-45ed-86b3-160cbbec3996"),
                            FatherName = "Lee",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"),
                            MotherName = "Worm",
                            SecondName = "Emilio",
                            TutorId = new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d")
                        },
                        new
                        {
                            Id = new Guid("056a4650-ef32-46f1-9a4d-4b8ab28c142c"),
                            FatherName = "Escobar",
                            FirstName = "Johan",
                            KindergarterId = new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"),
                            MotherName = "Snow",
                            SecondName = "Enrique",
                            TutorId = new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d")
                        },
                        new
                        {
                            Id = new Guid("05bf9154-4750-410f-b6c1-99d2320d794a"),
                            FatherName = "Stackeetam",
                            FirstName = "Johan",
                            KindergarterId = new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"),
                            MotherName = "Snow",
                            SecondName = "Enrique",
                            TutorId = new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d")
                        },
                        new
                        {
                            Id = new Guid("06645412-9112-4d7f-869c-5a6f87998a58"),
                            FatherName = "Faringtom",
                            FirstName = "Johan",
                            KindergarterId = new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"),
                            MotherName = "Worm",
                            SecondName = "Eduardo",
                            TutorId = new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d")
                        });
                });

            modelBuilder.Entity("KindergartenAppService.Models.Kindergarter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Kindergarters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b605e75-25ed-422a-934f-d6572b43eedc"),
                            Description = "Guarderia"
                        });
                });

            modelBuilder.Entity("KindergartenAppService.Models.MedicalRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("KidId");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.ToTable("MedicalRecord");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Payment", b =>
                {
                    b.Property<Guid>("InvoiceId");

                    b.Property<Guid>("ReceiptId");

                    b.HasKey("InvoiceId", "ReceiptId");

                    b.HasIndex("ReceiptId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Precense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("KidId");

                    b.Property<DateTime>("PrecenseDay");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.ToTable("Precense");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Receipt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Receipt");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Stock", b =>
                {
                    b.Property<Guid>("StoreId");

                    b.Property<Guid>("ProductId");

                    b.HasKey("StoreId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Store", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Tutor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Mail");

                    b.Property<string>("MovilNumber");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Tutors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7c3cdebd-f46c-4cdd-8b55-faeac24de69d"),
                            FirstName = "Gregorio de Jesus",
                            LastName = "Rojas Acosta"
                        },
                        new
                        {
                            Id = new Guid("380a7446-94f4-480f-9806-5091afcde014"),
                            FirstName = "Yadira",
                            LastName = "Pinales Delgado"
                        });
                });

            modelBuilder.Entity("KindergartenAppService.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("KindergarterId");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("KindergarterId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Product", b =>
                {
                    b.HasBaseType("KindergartenAppService.Models.Item");

                    b.HasDiscriminator().HasValue("Product");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Service", b =>
                {
                    b.HasBaseType("KindergartenAppService.Models.Item");

                    b.Property<Guid>("ActivityId");

                    b.Property<string>("Description");

                    b.HasIndex("ActivityId");

                    b.HasDiscriminator().HasValue("Service");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Activity", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kindergarter", "Kindergarter")
                        .WithMany("Activities")
                        .HasForeignKey("KindergarterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.EnrollActivity", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KindergartenAppService.Models.Enrollment")
                        .WithMany("EnrollActivities")
                        .HasForeignKey("EnrollmentId");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Enrollment", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kid", "Kid")
                        .WithMany()
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.FeedingKid", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Feeding", "Fedding")
                        .WithMany("FeedingKids")
                        .HasForeignKey("FeddingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KindergartenAppService.Models.Kid", "Kid")
                        .WithMany("FeedingKids")
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Invoice", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kid", "Kid")
                        .WithMany()
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.InvoiceDetail", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Invoice")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("KindergartenAppService.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Kid", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kindergarter", "Kindergarter")
                        .WithMany("Kids")
                        .HasForeignKey("KindergarterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KindergartenAppService.Models.Tutor", "Tutor")
                        .WithMany("Kids")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.MedicalRecord", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kid", "Kid")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Payment", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Invoice", "Invoice")
                        .WithMany("Payments")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KindergartenAppService.Models.Receipt", "Receipt")
                        .WithMany("Payments")
                        .HasForeignKey("ReceiptId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Precense", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kid", "Kid")
                        .WithMany("Precenses")
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Stock", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Product", "Product")
                        .WithMany("Stock")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KindergartenAppService.Models.Store", "Store")
                        .WithMany("Stock")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.User", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kindergarter", "Kindergarter")
                        .WithMany("Users")
                        .HasForeignKey("KindergarterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Service", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}