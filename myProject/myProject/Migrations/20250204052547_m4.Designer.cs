﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myProject.Models;

#nullable disable

namespace myProject.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20250204052547_m4")]
    partial class m4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("myProject.Models.Adoptions", b =>
                {
                    b.Property<int>("AdoptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdoptionID"));

                    b.Property<DateTime>("AdoptionDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("adopterId")
                        .HasColumnType("int");

                    b.Property<int>("petId")
                        .HasColumnType("int");

                    b.HasKey("AdoptionID");

                    b.HasIndex("adopterId");

                    b.HasIndex("petId");

                    b.ToTable("Adoptions");
                });

            modelBuilder.Entity("myProject.Models.MedicalRecords", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("DateTime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NextAppointment")
                        .HasColumnType("DateTime");

                    b.Property<string>("VetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("petId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("petId");

                    b.ToTable("Medical");
                });

            modelBuilder.Entity("myProject.Models.Members", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("F_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("L_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("myProject.Models.Pets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdopterId")
                        .HasColumnType("int");

                    b.Property<bool>("AdoptionStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("DateTime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdopterId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("myProject.Models.Adoptions", b =>
                {
                    b.HasOne("myProject.Models.Members", "Adopter")
                        .WithMany()
                        .HasForeignKey("adopterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("myProject.Models.Pets", "AdoptedPet")
                        .WithMany("adoptions")
                        .HasForeignKey("petId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdoptedPet");

                    b.Navigation("Adopter");
                });

            modelBuilder.Entity("myProject.Models.MedicalRecords", b =>
                {
                    b.HasOne("myProject.Models.Pets", "pet")
                        .WithMany("Records")
                        .HasForeignKey("petId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pet");
                });

            modelBuilder.Entity("myProject.Models.Pets", b =>
                {
                    b.HasOne("myProject.Models.Members", "Adopter")
                        .WithMany("Adoptedpets")
                        .HasForeignKey("AdopterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adopter");
                });

            modelBuilder.Entity("myProject.Models.Members", b =>
                {
                    b.Navigation("Adoptedpets");
                });

            modelBuilder.Entity("myProject.Models.Pets", b =>
                {
                    b.Navigation("Records");

                    b.Navigation("adoptions");
                });
#pragma warning restore 612, 618
        }
    }
}
