using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HTO.Authorization.Roles;
using HTO.Authorization.Users;
using HTO.MultiTenancy;

namespace HTO.EntityFrameworkCore
{
    public class HTODbContext : AbpZeroDbContext<Tenant, Role, User, HTODbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HTODbContext(DbContextOptions<HTODbContext> options)
            : base(options)
        {
        }
    }
}
