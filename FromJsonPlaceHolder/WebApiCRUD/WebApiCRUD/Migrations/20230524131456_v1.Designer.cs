﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiCRUD.Model;

#nullable disable

namespace WebApiCRUD.Migrations
{
    [DbContext(typeof(YazarKitapDbContext))]
    [Migration("20230524131456_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApiCRUD.Model.Kitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("KitapAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SayfaSayisi")
                        .HasColumnType("int");

                    b.Property<int>("YazarId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YazarId");

                    b.ToTable("Kitaps");
                });

            modelBuilder.Entity("WebApiCRUD.Model.KitapTur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("KitapId")
                        .HasColumnType("int");

                    b.Property<int>("TurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KitapId");

                    b.HasIndex("TurId");

                    b.ToTable("KitapTurs");
                });

            modelBuilder.Entity("WebApiCRUD.Model.Tur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TurAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Turs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TurAd = "Macera"
                        },
                        new
                        {
                            Id = 2,
                            TurAd = "Roman"
                        },
                        new
                        {
                            Id = 3,
                            TurAd = "BilimKurgu"
                        },
                        new
                        {
                            Id = 4,
                            TurAd = "Gizem"
                        },
                        new
                        {
                            Id = 5,
                            TurAd = "Biyografi"
                        },
                        new
                        {
                            Id = 6,
                            TurAd = "Felsefe"
                        });
                });

            modelBuilder.Entity("WebApiCRUD.Model.Yazar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("YazarAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YazarSoyAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Yazars");
                });

            modelBuilder.Entity("WebApiCRUD.Model.Kitap", b =>
                {
                    b.HasOne("WebApiCRUD.Model.Yazar", "Yazar")
                        .WithMany("Kitaps")
                        .HasForeignKey("YazarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("WebApiCRUD.Model.KitapTur", b =>
                {
                    b.HasOne("WebApiCRUD.Model.Kitap", "Kitap")
                        .WithMany("Turs")
                        .HasForeignKey("KitapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiCRUD.Model.Tur", "Tur")
                        .WithMany("Kitaps")
                        .HasForeignKey("TurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kitap");

                    b.Navigation("Tur");
                });

            modelBuilder.Entity("WebApiCRUD.Model.Kitap", b =>
                {
                    b.Navigation("Turs");
                });

            modelBuilder.Entity("WebApiCRUD.Model.Tur", b =>
                {
                    b.Navigation("Kitaps");
                });

            modelBuilder.Entity("WebApiCRUD.Model.Yazar", b =>
                {
                    b.Navigation("Kitaps");
                });
#pragma warning restore 612, 618
        }
    }
}
