﻿// <auto-generated />
using System;
using Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(AcademyContext))]
    [Migration("20221123203335_AddDbSetForLinkingTables")]
    partial class AddDbSetForLinkingTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Models.Lecturer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte>("YearsOfExperience")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("Data.Models.LecturersSubjects", b =>
                {
                    b.Property<Guid>("KeyA")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KeyB")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("KeyA", "KeyB");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("KeyB");

                    b.ToTable("LecturersSubjects");
                });

            modelBuilder.Entity("Data.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Data.Models.StudentsSubjects", b =>
                {
                    b.Property<Guid>("KeyA")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KeyB")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("KeyA", "KeyB");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("KeyB");

                    b.ToTable("StudentsSubjects");
                });

            modelBuilder.Entity("Data.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte>("ExecutionTime")
                        .HasColumnType("tinyint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IsDeleted");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Data.Models.LecturersSubjects", b =>
                {
                    b.HasOne("Data.Models.Lecturer", "Lecturer")
                        .WithMany("Subjects")
                        .HasForeignKey("KeyA")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.Models.Subject", "Subject")
                        .WithMany("Lecturers")
                        .HasForeignKey("KeyB")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Lecturer");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Data.Models.StudentsSubjects", b =>
                {
                    b.HasOne("Data.Models.Student", "Student")
                        .WithMany("Subjects")
                        .HasForeignKey("KeyA")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.Models.Subject", "Subject")
                        .WithMany("Students")
                        .HasForeignKey("KeyB")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Data.Models.Lecturer", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("Data.Models.Student", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("Data.Models.Subject", b =>
                {
                    b.Navigation("Lecturers");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
