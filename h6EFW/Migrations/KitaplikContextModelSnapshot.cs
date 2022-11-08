﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using h6EFW.Models;

#nullable disable

namespace h6EFW.Migrations
{
    [DbContext(typeof(KitaplikContext))]
    partial class KitaplikContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("h6EFW.Models.Kitap", b =>
                {
                    b.Property<int>("KitapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitapID"));

                    b.Property<string>("KitapAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitapSayfasi")
                        .HasColumnType("int");

                    b.Property<int>("YazarID")
                        .HasColumnType("int");

                    b.HasKey("KitapID");

                    b.HasIndex("YazarID");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("h6EFW.Models.Yazar", b =>
                {
                    b.Property<int>("YazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YazarID"));

                    b.Property<string>("YazarAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YazarID");

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("h6EFW.Models.Kitap", b =>
                {
                    b.HasOne("h6EFW.Models.Yazar", "Yazar")
                        .WithMany("Kitaplar")
                        .HasForeignKey("YazarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("h6EFW.Models.Yazar", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}
