﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

namespace WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200510074506_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("WebApi.Models.Player", b =>
                {
                    b.Property<string>("PlayerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("WebApi.Models.RankDate", b =>
                {
                    b.Property<int>("RankDateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlayerId")
                        .HasColumnType("TEXT");

                    b.Property<int>("RankingNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("RankDateId");

                    b.ToTable("RankDates");
                });
#pragma warning restore 612, 618
        }
    }
}
