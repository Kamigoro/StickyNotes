using Microsoft.EntityFrameworkCore;

namespace StickyGO.Models.DataAccess
{
    public class NoteContext : DbContext
    {
        public DbSet<StickyNote> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Todo.db");

    }
}
