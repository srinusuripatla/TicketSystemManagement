using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TicketSystem.API.Models
{
    public partial class TicketDbContext : DbContext
    {
        public TicketDbContext()
        {
        }

        public TicketDbContext(DbContextOptions<TicketDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<Ticketcomment> Ticketcomments { get; set; } = null!;
        public virtual DbSet<Ticketstatushistory> Ticketstatushistories { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public object Ticketstatushistory { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=TicketSystem;user=root;password=srinu@7093", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("tickets");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("text");

                

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(100);

                entity.Property(e => e.TicketNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<Ticketcomment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PRIMARY");

                entity.ToTable("ticketcomments");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.Property(e => e.CommentedBy).HasMaxLength(100);
            });

            modelBuilder.Entity<Ticketstatushistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("ticketstatushistory");

                entity.Property(e => e.NewStatus).HasMaxLength(50);

                entity.Property(e => e.OldStatus).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");
                entity.ToTable("users");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(10);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
