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
    [Migration("20190714220417_Fixing_tutor_Feeding")]
    partial class Fixing_tutor_Feeding
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

                    b.Property<string>("Description");

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
                            Id = new Guid("04d4d650-bfcb-4a5e-8707-600775b4a361"),
                            FatherName = "Stackeetam",
                            FirstName = "Dylan",
                            KindergarterId = new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"),
                            MotherName = "White",
                            SecondName = "Eduardo",
                            TutorId = new Guid("0adeff61-3aed-416e-a452-4f6e14565d21")
                        },
                        new
                        {
                            Id = new Guid("05c79ad7-1d07-45d9-8321-781ff9974df6"),
                            FatherName = "Lee",
                            FirstName = "Dylan",
                            KindergarterId = new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"),
                            MotherName = "White",
                            SecondName = "Enrique",
                            TutorId = new Guid("0adeff61-3aed-416e-a452-4f6e14565d21")
                        },
                        new
                        {
                            Id = new Guid("066f6d6d-a1c5-4e36-b3d2-0db0189a15f4"),
                            FatherName = "Lee",
                            FirstName = "Johan",
                            KindergarterId = new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"),
                            MotherName = "Washinton",
                            SecondName = "Eduardo",
                            TutorId = new Guid("0adeff61-3aed-416e-a452-4f6e14565d21")
                        },
                        new
                        {
                            Id = new Guid("0b2e9aa5-a42d-43ae-9c7c-518ce82383eb"),
                            FatherName = "Lee",
                            FirstName = "Johan",
                            KindergarterId = new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"),
                            MotherName = "Snow",
                            SecondName = "Carlos",
                            TutorId = new Guid("0adeff61-3aed-416e-a452-4f6e14565d21")
                        },
                        new
                        {
                            Id = new Guid("0bf0523b-99fc-4c18-b653-f69ff53b9122"),
                            FatherName = "Lee",
                            FirstName = "Aaron",
                            KindergarterId = new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"),
                            MotherName = "Worm",
                            SecondName = "Enrique",
                            TutorId = new Guid("0adeff61-3aed-416e-a452-4f6e14565d21")
                        },
                        new
                        {
                            Id = new Guid("0e64cf03-313c-42e2-a193-dcf2aa6ca1fc"),
                            FatherName = "Lee",
                            FirstName = "Aaron",
                            KindergarterId = new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"),
                            MotherName = "Snow",
                            SecondName = "Carlos",
                            TutorId = new Guid("0adeff61-3aed-416e-a452-4f6e14565d21")
                        },
                        new
                        {
                            Id = new Guid("10f96eea-82b3-43bf-a74b-bb6783e7116b"),
                            FatherName = "Escobar",
                            FirstName = "Johan",
                            KindergarterId = new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"),
                            MotherName = "Snow",
                            SecondName = "Eduardo",
                            TutorId = new Guid("0adeff61-3aed-416e-a452-4f6e14565d21")
                        },
                        new
                        {
                            Id = new Guid("11c446f8-3621-4aab-9d97-09a14b07dd8f"),
                            FatherName = "Escobar",
                            FirstName = "Johan",
                            KindergarterId = new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"),
                            MotherName = "White",
                            SecondName = "Eduardo",
                            TutorId = new Guid("0adeff61-3aed-416e-a452-4f6e14565d21")
                        },
                        new
                        {
                            Id = new Guid("120a9b81-0f3a-4a68-8b3b-83e3dac9b6cf"),
                            FatherName = "Escobar",
                            FirstName = "Aaron",
                            KindergarterId = new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"),
                            MotherName = "Worm",
                            SecondName = "Eduardo",
                            TutorId = new Guid("0adeff61-3aed-416e-a452-4f6e14565d21")
                        },
                        new
                        {
                            Id = new Guid("12631c61-889b-4ffe-b3b4-ff78ccc31137"),
                            FatherName = "Faringtom",
                            FirstName = "Dylan",
                            KindergarterId = new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"),
                            MotherName = "Snow",
                            SecondName = "Emilio",
                            TutorId = new Guid("0adeff61-3aed-416e-a452-4f6e14565d21")
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
                            Id = new Guid("ef6c5692-9813-439b-aa2e-d77ebe9e2d67"),
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

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Tutor");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0adeff61-3aed-416e-a452-4f6e14565d21"),
                            FirstName = "Gregorio de Jesus",
                            LastName = "Rojas Acosta"
                        },
                        new
                        {
                            Id = new Guid("6b079598-baa6-4098-9d7f-f5124b61e050"),
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
                        .WithMany()
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
