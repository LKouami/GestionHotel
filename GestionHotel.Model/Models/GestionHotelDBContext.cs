using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GestionHotel.Model.Models
{
    public partial class GestionHotelDBContext : DbContext
    {
        public GestionHotelDBContext()
        {
        }

        public GestionHotelDBContext(DbContextOptions<GestionHotelDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AClaim> AClaim { get; set; }
        public virtual DbSet<AConnections> AConnections { get; set; }
        public virtual DbSet<ARole> ARole { get; set; }
        public virtual DbSet<ARoleClaim> ARoleClaim { get; set; }
        public virtual DbSet<AUser> AUser { get; set; }
        public virtual DbSet<AUserClaim> AUserClaim { get; set; }
        public virtual DbSet<AUserRole> AUserRole { get; set; }
        public virtual DbSet<SClient> SClient { get; set; }
        public virtual DbSet<SEspace> SEspace { get; set; }
        public virtual DbSet<SEtatEspace> SEtatEspace { get; set; }
        public virtual DbSet<SPromotion> SPromotion { get; set; }
        public virtual DbSet<SReserver> SReserver { get; set; }
        public virtual DbSet<STypeClient> STypeClient { get; set; }
        public virtual DbSet<STypeEspace> STypeEspace { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-J7BTT8V\\SQLEXPRESS;Database=GestionHotelDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AClaim>(entity =>
            {
                entity.ToTable("A_Claim");

                entity.HasIndex(e => e.Name)
                    .HasName("Uk_A_Claim")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AConnections>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("A_Connections");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<ARole>(entity =>
            {
                entity.ToTable("A_Role");

                entity.HasIndex(e => e.Name)
                    .HasName("Uk_A_Role")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ARoleClaim>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ClaimId })
                    .HasName("Pk_A_RoleClaim");

                entity.ToTable("A_RoleClaim");

                entity.Property(e => e.ClaimValue)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<AUser>(entity =>
            {
                entity.ToTable("A_User");

                entity.HasIndex(e => e.Email)
                    .HasName("UK_A_User")
                    .IsUnique();

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Firstname).HasMaxLength(255);

                entity.Property(e => e.Lastname).HasMaxLength(255);

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Token).HasMaxLength(200);
            });

            modelBuilder.Entity<AUserClaim>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ClaimId })
                    .HasName("Pk_A_UserClaim");

                entity.ToTable("A_UserClaim");

                entity.Property(e => e.ClaimValue)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<AUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("Pk_A_UserRole");

                entity.ToTable("A_UserRole");
            });

            modelBuilder.Entity<SClient>(entity =>
            {
                entity.ToTable("S_Client");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.DomicileHabituel).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.Nationalite).HasMaxLength(50);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prenom).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);
            });

            modelBuilder.Entity<SEspace>(entity =>
            {
                entity.ToTable("S_Espace");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Situation).HasMaxLength(50);
            });

            modelBuilder.Entity<SEtatEspace>(entity =>
            {
                entity.ToTable("S_EtatEspace");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");
            });

            modelBuilder.Entity<SPromotion>(entity =>
            {
                entity.ToTable("S_Promotion");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");
            });

            modelBuilder.Entity<SReserver>(entity =>
            {
                entity.ToTable("S_Reserver");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.EtatReservation).HasColumnName("etatReservation");

                entity.Property(e => e.Modalite).HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.Observation).HasMaxLength(256);

                entity.Property(e => e.OrigineReservation).HasMaxLength(50);

                entity.Property(e => e.PromotionId).HasColumnName("promotionId");
            });

            modelBuilder.Entity<STypeClient>(entity =>
            {
                entity.ToTable("S_TypeClient");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<STypeEspace>(entity =>
            {
                entity.ToTable("S_TypeEspace");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
