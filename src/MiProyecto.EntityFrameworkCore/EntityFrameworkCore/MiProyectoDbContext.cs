using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MiProyecto.Authorization.Roles;
using MiProyecto.Authorization.Users;
using MiProyecto.MultiTenancy;

namespace MiProyecto.EntityFrameworkCore
{
    public class MiProyectoDbContext : AbpZeroDbContext<Tenant, Role, User, MiProyectoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MiProyectoDbContext(DbContextOptions<MiProyectoDbContext> options)
            : base(options)
        {
        }
    }
}
