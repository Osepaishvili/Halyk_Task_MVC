using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HTO.Configuration;
using HTO.Web;

namespace HTO.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HTODbContextFactory : IDesignTimeDbContextFactory<HTODbContext>
    {
        public HTODbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HTODbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HTODbContextConfigurer.Configure(builder, configuration.GetConnectionString(HTOConsts.ConnectionStringName));

            return new HTODbContext(builder.Options);
        }
    }
}
