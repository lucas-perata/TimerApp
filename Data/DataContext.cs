using Microsoft.EntityFrameworkCore;
using TimerApp.Entity;

namespace TimerApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<TimeEntry> TimeEntries { get; set; }
    }
}
