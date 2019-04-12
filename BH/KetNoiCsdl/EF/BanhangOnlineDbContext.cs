namespace KetNoiCsdl.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BanhangOnlineDbContext : DbContext
    {
        public BanhangOnlineDbContext()
            : base("name=BanhangOnlineDbContext2")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<FeelBack> FeelBacks { get; set; }
        public virtual DbSet<OrderA> OrderAs { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(e => e.noidung)
                .IsUnicode(false);

            modelBuilder.Entity<OrderA>()
                .Property(e => e.gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderA>()
                .Property(e => e.thanhtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
