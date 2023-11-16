﻿// <auto-generated />
using BJGameDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BJGameDAL.Migrations
{
    [DbContext(typeof(DbConnection))]
    partial class DbConnectionModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BJGameEL.Hand", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<bool>("isBust")
                        .HasColumnType("bit");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Hands");
                });

            modelBuilder.Entity("BJGameEL.Player", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<bool>("isFinished")
                        .HasColumnType("bit");

                    b.Property<int>("playerId")
                        .HasColumnType("int");

                    b.Property<string>("playerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("winner")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("BJGameEL.Hand", b =>
                {
                    b.HasOne("BJGameEL.Player", null)
                        .WithOne("hand")
                        .HasForeignKey("BJGameEL.Hand", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BJGameEL.Player", b =>
                {
                    b.Navigation("hand");
                });
#pragma warning restore 612, 618
        }
    }
}
