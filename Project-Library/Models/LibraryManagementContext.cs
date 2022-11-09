﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Project_Library.Models
{
    public partial class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext()
        {
        }

        public LibraryManagementContext(DbContextOptions<LibraryManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<AuthorBook> AuthorBooks { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<BookInfo> BookInfos { get; set; } = null!;
        public virtual DbSet<LendBookDetail> LendBookDetails { get; set; } = null!;
        public virtual DbSet<Librarian> Librarians { get; set; } = null!;
        public virtual DbSet<Publisher> Publishers { get; set; } = null!;
        public virtual DbSet<Reader> Readers { get; set; } = null!;
        public virtual DbSet<ReturnBook> ReturnBooks { get; set; } = null!;
        public virtual DbSet<ReturnBookDetail> ReturnBookDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                string conStr = config.GetConnectionString("LibraryCS");
                optionsBuilder.UseSqlServer(conStr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK_Account_Username");

                entity.ToTable("Account");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Gmail).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.HasOne(d => d.Librarian)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.LibrarianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Librarian");
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("Author");

                entity.Property(e => e.AuthorName).HasMaxLength(30);
            });

            modelBuilder.Entity<AuthorBook>(entity =>
            {
                entity.HasKey(e => new { e.AuthorId, e.TitleId })
                    .HasName("PK_AuthorId_TitleId");

                entity.ToTable("AuthorBook");

                entity.Property(e => e.AuthorRole).HasMaxLength(30);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.AuthorBooks)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorId");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.AuthorBooks)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TitleId");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_Title");

                entity.HasMany(d => d.LendBookDetails)
                    .WithMany(p => p.Books)
                    .UsingEntity<Dictionary<string, object>>(
                        "LendBook",
                        l => l.HasOne<LendBookDetail>().WithMany().HasForeignKey("LendBookDetailId").OnDelete(DeleteBehavior.ClientCascade).HasConstraintName("FK_LendBookDetail"),
                        r => r.HasOne<Book>().WithMany().HasForeignKey("BookId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Book"),
                        j =>
                        {
                            j.HasKey("BookId", "LendBookDetailId");

                            j.ToTable("LendBook");
                        });
            });

            modelBuilder.Entity<BookInfo>(entity =>
            {
                entity.HasKey(e => e.TitleId)
                    .HasName("PK_TitleId");

                entity.ToTable("BookInfo");

                entity.Property(e => e.Frequency).HasDefaultValueSql("((0))");

                entity.Property(e => e.InStock).HasDefaultValueSql("('0')");

                entity.Property(e => e.Title).HasMaxLength(30);

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.BookInfos)
                    .HasForeignKey(d => d.PublisherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookInfo_Publisher");
            });

            modelBuilder.Entity<LendBookDetail>(entity =>
            {
                entity.ToTable("LendBookDetail");

                entity.Property(e => e.ExpectedReturnDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LendDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnCondition).HasMaxLength(30);

                entity.HasOne(d => d.CardNumberNavigation)
                    .WithMany(p => p.LendBookDetails)
                    .HasForeignKey(d => d.CardNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reader_Borrow");

                entity.HasOne(d => d.Librarian)
                    .WithMany(p => p.LendBookDetails)
                    .HasForeignKey(d => d.LibrarianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Librarian_Lend");
            });

            modelBuilder.Entity<Librarian>(entity =>
            {
                entity.ToTable("Librarian");

                entity.Property(e => e.LibrarianName).HasMaxLength(30);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("Publisher");

                entity.Property(e => e.PublisherName).HasMaxLength(50);
            });

            modelBuilder.Entity<Reader>(entity =>
            {
                entity.HasKey(e => e.CardNumber);

                entity.ToTable("Reader");

                entity.Property(e => e.Address).HasMaxLength(30);

                entity.Property(e => e.CardCreationDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FullName).HasMaxLength(30);

                entity.Property(e => e.Occupation).HasMaxLength(30);
            });

            modelBuilder.Entity<ReturnBook>(entity =>
            {
                entity.HasKey(e => e.ReturnId)
                    .HasName("PK_Return");

                entity.ToTable("ReturnBook");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CardNumberNavigation)
                    .WithMany(p => p.ReturnBooks)
                    .HasForeignKey(d => d.CardNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Card_Number");

                entity.HasOne(d => d.Librarian)
                    .WithMany(p => p.ReturnBooks)
                    .HasForeignKey(d => d.LibrarianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Librarian");
            });

            modelBuilder.Entity<ReturnBookDetail>(entity =>
            {
                entity.HasKey(e => new { e.ReturnId, e.BookId })
                    .HasName("PK_Return_Detail");

                entity.ToTable("ReturnBookDetail");

                entity.Property(e => e.ReturnCondition).HasMaxLength(30);

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.ReturnBookDetails)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Book_ReturnDetail");

                entity.HasOne(d => d.Return)
                    .WithMany(p => p.ReturnBookDetails)
                    .HasForeignKey(d => d.ReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Return_ReturnDetail");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}