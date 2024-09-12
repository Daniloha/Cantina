using Microsoft.EntityFrameworkCore;

namespace CantinaBackEnd.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<T> GetTable<T>() where T : class
        {
            return Set<T>();
        }
    }
}
