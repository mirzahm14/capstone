// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240410082824_ScheduleModelInit")]
    partial class ScheduleModelInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApi.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.Property<int>("Semesters")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("WebApi.Models.CourseClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseTypeId");

                    b.ToTable("CourseClasses");
                });

            modelBuilder.Entity("WebApi.Models.CourseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("CourseTypeT")
                        .HasColumnType("int");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseTypes");
                });

            modelBuilder.Entity("WebApi.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseClassId")
                        .HasColumnType("int");

                    b.Property<int>("MeetNumber")
                        .HasColumnType("int");

                    b.Property<int>("Teacher")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseClassId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("WebApi.Models.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("WebApi.Models.CourseClass", b =>
                {
                    b.HasOne("WebApi.Models.CourseType", "CourseTypes")
                        .WithMany("CourseClasses")
                        .HasForeignKey("CourseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseTypes");
                });

            modelBuilder.Entity("WebApi.Models.CourseType", b =>
                {
                    b.HasOne("WebApi.Models.Course", "Courses")
                        .WithMany("CourseTypes")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("WebApi.Models.Schedule", b =>
                {
                    b.HasOne("WebApi.Models.CourseClass", "CourseClass")
                        .WithMany("Schedules")
                        .HasForeignKey("CourseClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseClass");
                });

            modelBuilder.Entity("WebApi.Models.Course", b =>
                {
                    b.Navigation("CourseTypes");
                });

            modelBuilder.Entity("WebApi.Models.CourseClass", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("WebApi.Models.CourseType", b =>
                {
                    b.Navigation("CourseClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
