﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TrackerHook;

namespace TrackerHook.Migrations
{
    [DbContext(typeof(TrackerContext))]
    partial class TrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrackerHook.Tracker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeviceNickName");

                    b.Property<string>("DevicePhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Tracker");
                });

            modelBuilder.Entity("TrackerHook.TrackerEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsAlert");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<DateTime>("Time");

                    b.Property<int>("TrackerId");

                    b.HasKey("Id");

                    b.HasIndex("TrackerId");

                    b.ToTable("TrackerEvents");
                });

            modelBuilder.Entity("TrackerHook.TrackerEvent", b =>
                {
                    b.HasOne("TrackerHook.Tracker", "Tracker")
                        .WithMany("TrackerEvents")
                        .HasForeignKey("TrackerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
