using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using App11;

namespace App11
{
    [DbContext(typeof(myContext))]
    partial class myContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
