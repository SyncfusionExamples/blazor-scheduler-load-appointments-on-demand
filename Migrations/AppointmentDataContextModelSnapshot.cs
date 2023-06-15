﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchedulerLoadOnDemand.Data;

#nullable disable

namespace SchedulerLoadOnDemand.Migrations
{
    [DbContext(typeof(AppointmentDataContext))]
    partial class AppointmentDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchedulerLoadOnDemand.Data.AppointmentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndTimezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAllDay")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsBlock")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsReadOnly")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecurrenceException")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecurrenceID")
                        .HasColumnType("int");

                    b.Property<string>("RecurrenceRule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartTimezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppointmentDataSet");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndTime = new DateTime(2023, 6, 4, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            IsAllDay = false,
                            Location = "Tamilnadu",
                            StartTime = new DateTime(2023, 6, 4, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "Meeting"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
