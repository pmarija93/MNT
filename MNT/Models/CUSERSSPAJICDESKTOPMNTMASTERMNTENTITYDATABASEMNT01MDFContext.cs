using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MNT.Models
{
    public partial class CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext : DbContext
    {
        public CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext()
        {
        }

        public CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext(DbContextOptions<CUSERSSPAJICDESKTOPMNTMASTERMNTENTITYDATABASEMNT01MDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleCategory> ArticleCategory { get; set; }
        public virtual DbSet<ArticleSubCategory> ArticleSubCategory { get; set; }
        public virtual DbSet<ArticleSubWorkcenter> ArticleSubWorkcenter { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Shelfs> Shelfs { get; set; }
        public virtual DbSet<SubWorkcenter> SubWorkcenter { get; set; }
        public virtual DbSet<ToolShelf> ToolShelf { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserGroups> UserGroups { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<Workcenter> Workcenter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\User\\Desktop\\MNT-master\\MNT.Entity\\Database\\MNT01.mdf;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArticleAddDate).HasColumnType("datetime");

                entity.Property(e => e.ArticleCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleDescription).IsUnicode(false);

                entity.Property(e => e.ArticleLastRevision).HasColumnType("datetime");

                entity.Property(e => e.ArticleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleShelfId).HasColumnName("ArticleShelfID");

                entity.Property(e => e.ArticleSubCategoryId).HasColumnName("ArticleSubCategoryID");

                entity.Property(e => e.SubWorkcenterFk).HasColumnName("SubWorkcenterFK");
            });

            modelBuilder.Entity<ArticleCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleCategoryCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleCategoryName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArticleSubCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticleCategoryId).HasColumnName("ArticleCategoryID");

                entity.Property(e => e.ArticleSubCategoryCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ArticleSubCategoryName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArticleSubWorkcenter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.SubWorkcenterFk).HasColumnName("SubWorkcenterFK");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shelfs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ShelfCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShelfName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToolShelfId).HasColumnName("ToolShelfID");
            });

            modelBuilder.Entity<SubWorkcenter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SubWorkcenterAddDate).HasColumnType("datetime");

                entity.Property(e => e.SubWorkcenterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubWorkcenterName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WorkcenterFk).HasColumnName("WorkcenterFK");
            });

            modelBuilder.Entity<ToolShelf>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tscode)
                    .HasColumnName("TSCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tsname)
                    .HasColumnName("TSName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
            });

            modelBuilder.Entity<User>(entity =>
            {
           

                entity.Property(e => e.Password)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserGroups>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.UsersGroupName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.WarehouseCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Workcenter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.WorkcenterAddDate).HasColumnType("datetime");

                entity.Property(e => e.WorkcenterCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WorkcenterName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
