﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RMotownFestival.Api.Data;

namespace RMotownFestival.Api.Migrations
{
    [DbContext(typeof(MotownDbContext))]
    [Migration("20210302140321_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RMotownFestival.Api.Domain.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FestivalId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FestivalId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("RMotownFestival.Api.Domain.Festival", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LineUpId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LineUpId");

                    b.ToTable("Festivals");
                });

            modelBuilder.Entity("RMotownFestival.Api.Domain.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("RMotownFestival.Api.Domain.ScheduleItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArtistId")
                        .HasColumnType("int");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("bit");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int?>("StageId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("StageId");

                    b.ToTable("ScheduleItems");
                });

            modelBuilder.Entity("RMotownFestival.Api.Domain.Stage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FestivalId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FestivalId");

                    b.ToTable("Stages");
                });

            modelBuilder.Entity("RMotownFestival.Api.Domain.Artist", b =>
                {
                    b.HasOne("RMotownFestival.Api.Domain.Festival", null)
                        .WithMany("Artists")
                        .HasForeignKey("FestivalId");
                });

            modelBuilder.Entity("RMotownFestival.Api.Domain.Festival", b =>
                {
                    b.HasOne("RMotownFestival.Api.Domain.Schedule", "LineUp")
                        .WithMany()
                        .HasForeignKey("LineUpId");

                    b.Navigation("LineUp");
                });

            modelBuilder.Entity("RMotownFestival.Api.Domain.ScheduleItem", b =>
                {
                    b.HasOne("RMotownFestival.Api.Domain.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId");

                    b.HasOne("RMotownFestival.Api.Domain.Schedule", null)
                        .WithMany("Items")
                        .HasForeignKey("ScheduleId");

                    b.HasOne("RMotownFestival.Api.Domain.Stage", "Stage")
                        .WithMany()
                        .HasForeignKey("StageId");

                    b.Navigation("Artist");

                    b.Navigation("Stage");
                });

            modelBuilder.Entity("RMotownFestival.Api.Domain.Stage", b =>
                {
                    b.HasOne("RMotownFestival.Api.Domain.Festival", null)
                        .WithMany("Stages")
                        .HasForeignKey("FestivalId");
                });

            modelBuilder.Entity("RMotownFestival.Api.Domain.Festival", b =>
                {
                    b.Navigation("Artists");

                    b.Navigation("Stages");
                });

            modelBuilder.Entity("RMotownFestival.Api.Domain.Schedule", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
