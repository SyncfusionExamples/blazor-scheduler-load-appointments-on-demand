using Microsoft.EntityFrameworkCore;

namespace SchedulerLoadOnDemand.Data
{
    public class AppointmentDataContext : DbContext
    {
        public AppointmentDataContext(DbContextOptions<AppointmentDataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentData>().HasData(
                new AppointmentData
                {
					RecordId =1,
                    Id = 1,
                    Subject = "Meeting",
                    StartTime = new DateTime(2023, 6, 4, 9, 0, 0),
                    EndTime = new DateTime(2023, 6, 4, 10, 30, 0),
                    Location = "Tamilnadu"
                }
            );
        }
        public DbSet<AppointmentData> AppointmentDataSet { get; set; }
    }
}
