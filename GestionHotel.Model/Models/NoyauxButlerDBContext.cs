using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GestionHotel.Model.Models
{
    public partial class NoyauxButlerDBContext : DbContext
    {
        public NoyauxButlerDBContext()
        {
        }

        public NoyauxButlerDBContext(DbContextOptions<NoyauxButlerDBContext> options)
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
        public virtual DbSet<AffectationMaterielvue> AffectationMaterielvue { get; set; }
        public virtual DbSet<Clientvue> Clientvue { get; set; }
        public virtual DbSet<Espacevue> Espacevue { get; set; }
        public virtual DbSet<Locationvue> Locationvue { get; set; }
        public virtual DbSet<SAffectationMateriel> SAffectationMateriel { get; set; }
        public virtual DbSet<SClient> SClient { get; set; }
        public virtual DbSet<SEspace> SEspace { get; set; }
        public virtual DbSet<SEtatEspace> SEtatEspace { get; set; }
        public virtual DbSet<SLocation> SLocation { get; set; }
        public virtual DbSet<SMateriel> SMateriel { get; set; }
        public virtual DbSet<SOrganismePayeur> SOrganismePayeur { get; set; }
        public virtual DbSet<SPack> SPack { get; set; }
        public virtual DbSet<STypeClient> STypeClient { get; set; }
        public virtual DbSet<STypeEspace> STypeEspace { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-J7BTT8V\\SQLEXPRESS;Database=NoyauxButlerDB;Trusted_Connection=True;");
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

            modelBuilder.Entity<AffectationMaterielvue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("affectationMaterielvue");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.EsDescription).HasColumnName("ES.Description");

                entity.Property(e => e.EsNom)
                    .HasColumnName("ES.Nom")
                    .HasMaxLength(50);

                entity.Property(e => e.EsNumero)
                    .IsRequired()
                    .HasColumnName("ES.Numero")
                    .HasMaxLength(50);

                entity.Property(e => e.EsPrix).HasColumnName("ES.Prix");

                entity.Property(e => e.EsSituation)
                    .HasColumnName("ES.Situation")
                    .HasMaxLength(50);

                entity.Property(e => e.MaNom)
                    .IsRequired()
                    .HasColumnName("MA.Nom")
                    .HasMaxLength(256);

                entity.Property(e => e.MaQuantite).HasColumnName("MA.Quantite");

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");
            });

            modelBuilder.Entity<Clientvue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("clientvue");

                entity.Property(e => e.DomicileHabituel).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Nationalite).HasMaxLength(50);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrAdresse)
                    .HasColumnName("OR.Adresse")
                    .HasMaxLength(50);

                entity.Property(e => e.OrEmail)
                    .HasColumnName("OR.Email")
                    .HasMaxLength(50);

                entity.Property(e => e.OrId).HasColumnName("OR.Id");

                entity.Property(e => e.OrNom)
                    .HasColumnName("OR.Nom")
                    .HasMaxLength(50);

                entity.Property(e => e.OrStatus).HasColumnName("OR.Status");

                entity.Property(e => e.OrTel)
                    .HasColumnName("OR.Tel")
                    .HasMaxLength(50);

                entity.Property(e => e.Prenom).HasMaxLength(50);

                entity.Property(e => e.TcId).HasColumnName("TC.Id");

                entity.Property(e => e.TcNom)
                    .IsRequired()
                    .HasColumnName("TC.Nom")
                    .HasMaxLength(50);

                entity.Property(e => e.TcStatus).HasColumnName("TC.Status");

                entity.Property(e => e.Tel).HasMaxLength(50);
            });

            modelBuilder.Entity<Espacevue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("espacevue");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.EeLibelle)
                    .IsRequired()
                    .HasColumnName("EE.Libelle")
                    .HasMaxLength(256);

                entity.Property(e => e.EeValeur).HasColumnName("EE.Valeur");

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.Nom).HasMaxLength(50);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Situation).HasMaxLength(50);

                entity.Property(e => e.TeNom)
                    .IsRequired()
                    .HasColumnName("TE.Nom")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Locationvue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("locationvue");

                entity.Property(e => e.ClDateNaissance).HasColumnName("CL.DateNaissance");

                entity.Property(e => e.ClDomicileHabituel)
                    .HasColumnName("CL.DomicileHabituel")
                    .HasMaxLength(50);

                entity.Property(e => e.ClEmail)
                    .HasColumnName("CL.Email")
                    .HasMaxLength(50);

                entity.Property(e => e.ClId).HasColumnName("CL.Id");

                entity.Property(e => e.ClNationalite)
                    .HasColumnName("CL.Nationalite")
                    .HasMaxLength(50);

                entity.Property(e => e.ClNom)
                    .IsRequired()
                    .HasColumnName("CL.Nom")
                    .HasMaxLength(50);

                entity.Property(e => e.ClPrenom)
                    .HasColumnName("CL.Prenom")
                    .HasMaxLength(50);

                entity.Property(e => e.ClTel)
                    .HasColumnName("CL.Tel")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.EsDescription).HasColumnName("ES.Description");

                entity.Property(e => e.EsId).HasColumnName("ES.Id");

                entity.Property(e => e.EsNom)
                    .HasColumnName("ES.Nom")
                    .HasMaxLength(50);

                entity.Property(e => e.EsNumero)
                    .IsRequired()
                    .HasColumnName("ES.Numero")
                    .HasMaxLength(50);

                entity.Property(e => e.EsPrix).HasColumnName("ES.Prix");

                entity.Property(e => e.EsSituation)
                    .HasColumnName("ES.Situation")
                    .HasMaxLength(50);

                entity.Property(e => e.EtatLocation).HasColumnName("etatLocation");

                entity.Property(e => e.Modalite).HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.Observation).HasMaxLength(256);

                entity.Property(e => e.OrAdresse)
                    .HasColumnName("OR.Adresse")
                    .HasMaxLength(50);

                entity.Property(e => e.OrEmail)
                    .HasColumnName("OR.Email")
                    .HasMaxLength(50);

                entity.Property(e => e.OrId).HasColumnName("OR.Id");

                entity.Property(e => e.OrNom)
                    .HasColumnName("OR.Nom")
                    .HasMaxLength(50);

                entity.Property(e => e.OrTel)
                    .HasColumnName("OR.Tel")
                    .HasMaxLength(50);

                entity.Property(e => e.OrigineLocation).HasMaxLength(50);

                entity.Property(e => e.PaId).HasColumnName("PA.Id");

                entity.Property(e => e.PaLibelle)
                    .IsRequired()
                    .HasColumnName("PA.Libelle")
                    .HasMaxLength(50);

                entity.Property(e => e.PaTaux).HasColumnName("PA.Taux");

                entity.Property(e => e.PrixApayer).HasColumnName("PrixAPayer");
            });

            modelBuilder.Entity<SAffectationMateriel>(entity =>
            {
                entity.ToTable("S_AffectationMateriel");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.HasOne(d => d.Espace)
                    .WithMany(p => p.SAffectationMateriel)
                    .HasForeignKey(d => d.EspaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_AffectationMateriel_S_Espace");

                entity.HasOne(d => d.Materiel)
                    .WithMany(p => p.SAffectationMateriel)
                    .HasForeignKey(d => d.MaterielId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_AffectationMateriel_S_Materiel");
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

                entity.HasOne(d => d.Organisme)
                    .WithMany(p => p.SClient)
                    .HasForeignKey(d => d.OrganismeId)
                    .HasConstraintName("FK_S_Client_S_OrganismePayeur");

                entity.HasOne(d => d.TypeClient)
                    .WithMany(p => p.SClient)
                    .HasForeignKey(d => d.TypeClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_Client_S_TypeClient");
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

                entity.HasOne(d => d.EtatEspace)
                    .WithMany(p => p.SEspace)
                    .HasForeignKey(d => d.EtatEspaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_Espace_S_EtatLocation1");

                entity.HasOne(d => d.TypeEspace)
                    .WithMany(p => p.SEspace)
                    .HasForeignKey(d => d.TypeEspaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Espace_TypeEspace");
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

            modelBuilder.Entity<SLocation>(entity =>
            {
                entity.ToTable("S_Location");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.EtatLocation).HasColumnName("etatLocation");

                entity.Property(e => e.Modalite).HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.Observation).HasMaxLength(256);

                entity.Property(e => e.OrigineLocation).HasMaxLength(50);

                entity.Property(e => e.PackId).HasColumnName("packId");

                entity.Property(e => e.PrixApayer).HasColumnName("PrixAPayer");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.SLocation)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_S_Location_S_Client1");

                entity.HasOne(d => d.Espace)
                    .WithMany(p => p.SLocation)
                    .HasForeignKey(d => d.EspaceId)
                    .HasConstraintName("FK_S_Location_S_Espace");

                entity.HasOne(d => d.OrganismePayeur)
                    .WithMany(p => p.SLocation)
                    .HasForeignKey(d => d.OrganismePayeurId)
                    .HasConstraintName("FK_S_Location_S_OrganismePayeur");

                entity.HasOne(d => d.Pack)
                    .WithMany(p => p.SLocation)
                    .HasForeignKey(d => d.PackId)
                    .HasConstraintName("FK_S_Location_S_Pack");
            });

            modelBuilder.Entity<SMateriel>(entity =>
            {
                entity.ToTable("S_Materiel");

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<SOrganismePayeur>(entity =>
            {
                entity.ToTable("S_OrganismePayeur");

                entity.Property(e => e.Adresse).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnName("Created_At");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.DeletedAt).HasColumnName("Deleted_At");

                entity.Property(e => e.DeletedBy).HasColumnName("Deleted_By");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ModifiedAt).HasColumnName("Modified_At");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);
            });

            modelBuilder.Entity<SPack>(entity =>
            {
                entity.ToTable("S_Pack");

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
