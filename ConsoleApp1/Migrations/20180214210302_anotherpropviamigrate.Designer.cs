﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using App11;

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(myContext))]
    [Migration("20180214210302_anotherpropviamigrate")]
    partial class anotherpropviamigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.5");

            modelBuilder.Entity("App11.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ANOTHERNEWPROP");

                    b.Property<int>("Age");

                    b.Property<string>("NEWPROPERTYVIAMIGRATE");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Dogs");
                });
        }
    }
}
