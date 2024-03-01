﻿// <auto-generated />
using KU.Student.Starter.UI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KU.Student.Starter.UI.Migrations
{
    [DbContext(typeof(TutorDataContext))]
    [Migration("20230516184028_HeadTutorTableCourseUpdate")]
    partial class HeadTutorTableCourseUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("KU.Student.Starter.UI.Models.AdminUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AdminUsers");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfCubicles")
                        .HasColumnType("integer");

                    b.Property<bool>("PublishSchedule")
                        .HasColumnType("boolean");

                    b.Property<int>("ScheduleSplitCount")
                        .HasColumnType("integer");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.CourseTutor", b =>
                {
                    b.Property<int>("TutorId")
                        .HasColumnType("integer");

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.HasKey("TutorId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("TutorCourses");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.Cubicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("CubicleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CubicleNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CubiclePlace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cubicles");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.EditScheduleTexts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("BelowTable")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GoToTop")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MainTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NotPublishedText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EditScheduleTexts");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.HeadTutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<int>("HeadTutorsTutorId")
                        .HasColumnType("integer");

                    b.Property<int[]>("TutorIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.ToTable("HeadTutors");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.HeadTutorConnection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("HeadTutorId")
                        .HasColumnType("integer");

                    b.Property<int[]>("TutorIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.HasIndex("HeadTutorId");

                    b.ToTable("HeadTutorConnections");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.Period", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EndHour")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StartHour")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.PeriodCubicle", b =>
                {
                    b.Property<int>("PeriodCubicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("PeriodCubicleId"));

                    b.Property<int>("CubicleId")
                        .HasColumnType("integer");

                    b.Property<int>("PeriodTutorId")
                        .HasColumnType("integer");

                    b.HasKey("PeriodCubicleId");

                    b.HasIndex("CubicleId");

                    b.HasIndex("PeriodTutorId");

                    b.ToTable("PeriodCubicles");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.PeriodTutor", b =>
                {
                    b.Property<int>("PeriodTutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("PeriodTutorId"));

                    b.Property<int>("PeriodId")
                        .HasColumnType("integer");

                    b.Property<int>("TutorId")
                        .HasColumnType("integer");

                    b.HasKey("PeriodTutorId");

                    b.HasIndex("PeriodId");

                    b.HasIndex("TutorId");

                    b.ToTable("TutorPeriods");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WeeklyHour")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Tutors");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.TutorApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int[]>("CourseIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GPA")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int[]>("PeriodIds")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WeeklyHour")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("TutorApplications");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.CourseTutor", b =>
                {
                    b.HasOne("KU.Student.Starter.UI.Models.Course", "Course")
                        .WithMany("Tutors")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KU.Student.Starter.UI.Models.Tutor", "Tutor")
                        .WithMany("Courses")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.HeadTutorConnection", b =>
                {
                    b.HasOne("KU.Student.Starter.UI.Models.HeadTutor", "HeadTutor")
                        .WithMany("Tutors")
                        .HasForeignKey("HeadTutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HeadTutor");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.PeriodCubicle", b =>
                {
                    b.HasOne("KU.Student.Starter.UI.Models.Cubicle", "Cubicle")
                        .WithMany("PeriodTutors")
                        .HasForeignKey("CubicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KU.Student.Starter.UI.Models.PeriodTutor", "PeriodTutor")
                        .WithMany("Cubicles")
                        .HasForeignKey("PeriodTutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cubicle");

                    b.Navigation("PeriodTutor");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.PeriodTutor", b =>
                {
                    b.HasOne("KU.Student.Starter.UI.Models.Period", "Period")
                        .WithMany("Tutors")
                        .HasForeignKey("PeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KU.Student.Starter.UI.Models.Tutor", "Tutor")
                        .WithMany("Periods")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Period");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.Tutor", b =>
                {
                    b.HasOne("KU.Student.Starter.UI.Models.HeadTutorConnection", "HeadTutor")
                        .WithMany("Tutors")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HeadTutor");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.Course", b =>
                {
                    b.Navigation("Tutors");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.Cubicle", b =>
                {
                    b.Navigation("PeriodTutors");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.HeadTutor", b =>
                {
                    b.Navigation("Tutors");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.HeadTutorConnection", b =>
                {
                    b.Navigation("Tutors");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.Period", b =>
                {
                    b.Navigation("Tutors");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.PeriodTutor", b =>
                {
                    b.Navigation("Cubicles");
                });

            modelBuilder.Entity("KU.Student.Starter.UI.Models.Tutor", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Periods");
                });
#pragma warning restore 612, 618
        }
    }
}