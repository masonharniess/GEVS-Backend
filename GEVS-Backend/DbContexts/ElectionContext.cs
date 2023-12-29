using Microsoft.EntityFrameworkCore;
using GEVS_Backend.Entities;

namespace GEVS_Backend.DbContexts
{
  // The database context is the main class that coordinates Entity Framework functionality for a data model.
  public class ElectionContext : DbContext
  {
    // The options object provides configuration information for how the context should be set up. The : base(options) part calls the constructor of the base DbContext class, passing in the provided options.
    public ElectionContext(DbContextOptions<ElectionContext> options) : base(options) { }

    // DbSet is a class that represents a collection of entities from a specific table or entity type in a database. It serves as an interface to query, insert, update, and delete records in the corresponding database table.
    public DbSet<VoterEntity> Voters { get; set; } = null!;
    public DbSet<OfficerEntity> Officers { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<VoterEntity>().HasData(
        new VoterEntity()
        {
          VoterId = "mh652@student.le.ac.uk",
          Password = "password",
          FullName = "Mason Harniess",
          DateOfBirth = new DateOnly(2001, 02, 01)
        }
     );
    }
  }
}
