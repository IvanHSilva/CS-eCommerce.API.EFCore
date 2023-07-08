using Microsoft.EntityFrameworkCore;

namespace eCommerce.Models.FluentAPI {
    public class eCommerceFluentAPIContext : DbContext {

        // Database Connection with configure ennviroment and contructor
        public eCommerceFluentAPIContext(DbContextOptions<eCommerceFluentAPIContext> options)
            : base(options) { }

        // DBSets
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // Users
            modelBuilder.Entity<User>().ToTable("Usuarios");
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Id).ValueGeneratedOnAdd(); // Identity
            modelBuilder.Entity<User>().Property(u => u.Name).
                HasColumnName("Nome").HasMaxLength(70).IsRequired();

            // Contacts
            modelBuilder.Entity<User>().ToTable("Usuarios");

            // Addresses
            modelBuilder.Entity<User>().ToTable("Usuarios");

            // Departments
            modelBuilder.Entity<User>().ToTable("Usuarios");

            // Compositions / Navigations
            modelBuilder.Entity<User>().HasOne(u => u.Contact).
                WithOne(c => c.User).HasForeignKey<Contact>(c => c.UserId).
                OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<User>().HasMany(u => u.Addresses).
                WithOne(a => a.User).HasForeignKey(a => a.UserId).
                OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<User>().HasMany(u => u.Departments).
                WithMany(d => d.Users);
        }
    }
}
