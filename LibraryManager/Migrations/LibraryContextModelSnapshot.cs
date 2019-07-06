﻿// <auto-generated />
using LibraryManager.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryManager.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryManager.DbContext.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookStatus");

                    b.Property<int>("CatalogueId");

                    b.Property<string>("ISBN");

                    b.HasKey("BookId");

                    b.HasIndex("CatalogueId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryManager.DbContext.Models.BorrowInformation", b =>
                {
                    b.Property<int>("BorrowInformationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<int>("BorrowerId");

                    b.HasKey("BorrowInformationId");

                    b.HasIndex("BookId");

                    b.HasIndex("BorrowerId");

                    b.ToTable("BorrowInformation");
                });

            modelBuilder.Entity("LibraryManager.DbContext.Models.Borrower", b =>
                {
                    b.Property<int>("BorrowerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("BorrowerId");

                    b.ToTable("Borrowers");
                });

            modelBuilder.Entity("LibraryManager.DbContext.Models.Catalogue", b =>
                {
                    b.Property<int>("CatalogueId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookName");

                    b.Property<int>("NumberOfBooks");

                    b.HasKey("CatalogueId");

                    b.ToTable("Catalogues");
                });

            modelBuilder.Entity("LibraryManager.DbContext.Models.Book", b =>
                {
                    b.HasOne("LibraryManager.DbContext.Models.Catalogue", "Catalogue")
                        .WithMany("Books")
                        .HasForeignKey("CatalogueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LibraryManager.DbContext.Models.BorrowInformation", b =>
                {
                    b.HasOne("LibraryManager.DbContext.Models.Book", "Book")
                        .WithMany("BorrowInformation")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LibraryManager.DbContext.Models.Borrower", "Borrower")
                        .WithMany("BorrowInformation")
                        .HasForeignKey("BorrowerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
