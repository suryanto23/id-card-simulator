// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using id_card_simulator.Database;

#nullable disable

namespace id_card_simulator.Migrations
{
    [DbContext(typeof(IndexContext))]
    [Migration("20220222094238_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("id_card_simulator.Models.ResidentModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Hamlet")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<DateTime>("IssuedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MarriedStatus")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Neighborhood")
                        .HasColumnType("int");

                    b.Property<string>("Nin")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SubDistrict")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UrbanDistrict")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Residents");
                });
#pragma warning restore 612, 618
        }
    }
}
