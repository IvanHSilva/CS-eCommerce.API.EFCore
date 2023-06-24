using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database {
    public class eCommerceContext : DbContext {

        // Database Connection without configure ennviroment
        // Data Source=SERVIDOR\SQLSERVER;Initial Catalog=eCommerce;Integrated Security=True;
        //string DBConn = "Data Source=SERVIDOR\\SQLSERVER;Initial Catalog=eCommerce;Integrated Security=True;";
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    optionsBuilder.UseSqlServer(DBConn);
        //}

        // Database Connection with configure ennviroment and contructor
        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options) {}

        // DBSets
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Department> Departments { get; set; } = null!;

        // EF Seeds
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Eletrônicos" },
                new Department { Id = 2, Name = "Livros" },
                new Department { Id = 3, Name = "Informática" },
                new Department { Id = 4, Name = "Moda" },
                new Department { Id = 5, Name = "Beleza" },
                new Department { Id = 6, Name = "Cozinha" }
             );
        }
    }
}
