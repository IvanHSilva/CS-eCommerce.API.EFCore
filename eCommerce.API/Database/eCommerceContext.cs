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

    }
}
