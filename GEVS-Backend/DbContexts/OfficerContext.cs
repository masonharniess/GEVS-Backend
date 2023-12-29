using Microsoft.EntityFrameworkCore;
using GEVS_Backend.Entities;

namespace GEVS_Backend.DbContexts
{
    public class OfficerContext : DbContext
    {
        public OfficerContext(DbContextOptions<OfficerContext> options) : base(options) { }

        public DbSet<OfficerEntity> Officers { get; set; } = null!;
    }
}