using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MiProyecto.EntityFrameworkCore
{
    public static class MiProyectoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MiProyectoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MiProyectoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
