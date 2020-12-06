using MeetingPlanner.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace MeetingPlanner.DAL
{
    public class MeetingContext : DbContext
    {
        public MeetingContext() : base("MeetingContext")
        {
        }

        public DbSet<Hymn> Hymns { get; set; }
        public DbSet<Leader> Leaders { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}