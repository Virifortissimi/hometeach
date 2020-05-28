﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eagle_hometeach.src.Data;

namespace eagle_hometeach.src.Migrations.TeacherDb
{
    [DbContext(typeof(TeacherDbContext))]
    [Migration("20200525223406_FourthCreate")]
    partial class FourthCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eagle_hometeach.src.Models.TeacherDetail", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TeacherID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnName("FullName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("Phone")
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<string>("PictureLink")
                        .IsRequired()
                        .HasColumnName("PictureLink")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Subjects")
                        .IsRequired()
                        .HasColumnName("Subjects")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("YearsOfExperience")
                        .IsRequired()
                        .HasColumnName("YearsOfExperience")
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.HasKey("TeacherID");

                    b.ToTable("TeacherDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
