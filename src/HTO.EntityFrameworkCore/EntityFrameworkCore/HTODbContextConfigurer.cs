using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HTO.EntityFrameworkCore
{
    public static class HTODbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HTODbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HTODbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
