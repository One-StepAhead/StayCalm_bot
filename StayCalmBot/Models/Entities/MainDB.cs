using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StayCalmBot.Models.Entities
{
    public partial class MainDB : DbContext
    {
        public static MainDB Instance { get; private set; } = new MainDB();

        public MainDB()
        {
        }

        public MainDB(DbContextOptions<MainDB> options)
            : base(options)
        {
        }

        public virtual DbSet<Applicationsforconsultation> Applicationsforconsultations { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=LocalHost;database=MainDB;user=root;password=1234", ServerVersion.Parse("8.0.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Applicationsforconsultation>(entity =>
            {
                entity.ToTable("applicationsforconsultation");

                entity.HasIndex(e => e.ClientId, "ClientID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(100)
                    .HasColumnName("ClientID");

                entity.Property(e => e.ClientMessage).HasMaxLength(255);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Applicationsforconsultations)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("applicationsforconsultation_ibfk_1");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.ChatId)
                    .HasName("PRIMARY");

                entity.ToTable("client");

                entity.Property(e => e.ChatId).HasColumnName("ChatID");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasPrecision(10);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
