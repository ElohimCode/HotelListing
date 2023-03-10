// <auto-generated />
using System;
using HotelList.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelListing.Insfrasture.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230218133608_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelList.Core.Domain.Entities.Country", b =>
                {
                    b.Property<Guid>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries", (string)null);

                    b.HasData(
                        new
                        {
                            CountryId = new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"),
                            CountryCode = "JM",
                            CountryName = "Jamaica"
                        },
                        new
                        {
                            CountryId = new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"),
                            CountryCode = "TH",
                            CountryName = "Thailand"
                        },
                        new
                        {
                            CountryId = new Guid("12e15727-d369-49a9-8b13-bc22e9362179"),
                            CountryCode = "CH",
                            CountryName = "China"
                        },
                        new
                        {
                            CountryId = new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"),
                            CountryCode = "PT",
                            CountryName = "Palestinian Territory"
                        },
                        new
                        {
                            CountryId = new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"),
                            CountryCode = "BS",
                            CountryName = "Bahamas"
                        });
                });

            modelBuilder.Entity("HotelList.Core.Domain.Entities.Hotel", b =>
                {
                    b.Property<Guid>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HotelAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("HotelId");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels", (string)null);

                    b.HasData(
                        new
                        {
                            HotelId = new Guid("a7104362-6641-4e37-8a6c-994af5b56c25"),
                            HotelName = "Ben Resort Centre",
                            Rating = 4.5
                        },
                        new
                        {
                            HotelId = new Guid("91d88c68-bce7-46aa-8472-34ef6cb56719"),
                            HotelName = "Jen Resort Centre",
                            Rating = 4.0
                        },
                        new
                        {
                            HotelId = new Guid("a9da989c-5d4b-43df-a905-aaff4f75d82f"),
                            HotelName = "Zeus Resort Centre",
                            Rating = 3.7999999999999998
                        },
                        new
                        {
                            HotelId = new Guid("b455f8cb-b8ec-44af-8115-7bf00adc33d0"),
                            HotelName = "Zen Resort Centre",
                            Rating = 5.0
                        },
                        new
                        {
                            HotelId = new Guid("8d2bef80-abe6-4aa4-b549-c145806f9cd1"),
                            HotelName = "Bala Blu Resort Centre",
                            Rating = 4.0
                        },
                        new
                        {
                            HotelId = new Guid("c196b58a-6e17-499e-ba2d-10729f6c5a89"),
                            HotelName = "Nulen Resort Centre",
                            Rating = 3.5
                        });
                });

            modelBuilder.Entity("HotelList.Core.Domain.Entities.Hotel", b =>
                {
                    b.HasOne("HotelList.Core.Domain.Entities.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelList.Core.Domain.Entities.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
