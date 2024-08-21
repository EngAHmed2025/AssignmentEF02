﻿// <auto-generated />
using System;
using AssignmentEF02.Dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssignmentEF02.Migrations
{
    [DbContext(typeof(ITIDbcontext))]
    [Migration("20240821174804_RealtionEntity")]
    partial class RealtionEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssignmentEF02.Entites.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Duration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Course_Inst", b =>
                {
                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("inst_ID")
                        .HasColumnType("int");

                    b.Property<string>("evaluate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Course_ID", "inst_ID");

                    b.ToTable("Course_Insts");
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ins_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Ins_ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Bouns")
                        .HasColumnType("float");

                    b.Property<int?>("DepId")
                        .HasColumnType("int");

                    b.Property<int>("Dept_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("HourRate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ins_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DepId");

                    b.HasIndex("Dept_ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Stud_Course", b =>
                {
                    b.Property<int>("Course_ID")
                        .HasColumnType("int");

                    b.Property<int>("Stud_ID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("Course_ID", "Stud_ID");

                    b.ToTable("Stud_Courses");
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Students", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentsId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Top_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Top_ID")
                        .IsUnique();

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Department", b =>
                {
                    b.HasOne("AssignmentEF02.Entites.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("Ins_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Instructor", b =>
                {
                    b.HasOne("AssignmentEF02.Entites.Department", "Dep")
                        .WithMany()
                        .HasForeignKey("DepId");

                    b.HasOne("AssignmentEF02.Entites.Department", "Departments")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Dep");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Students", b =>
                {
                    b.HasOne("AssignmentEF02.Entites.Department", "Departments")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Topic", b =>
                {
                    b.HasOne("AssignmentEF02.Entites.Course", "Courses")
                        .WithOne("Top_ID")
                        .HasForeignKey("AssignmentEF02.Entites.Topic", "Top_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Course", b =>
                {
                    b.Navigation("Top_ID")
                        .IsRequired();
                });

            modelBuilder.Entity("AssignmentEF02.Entites.Department", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
