﻿using Microsoft.EntityFrameworkCore;

namespace Todo.Models.DataAccess
{
    public class NoteContext : DbContext
    {
        public DbSet<StickyNote> Notes { get; set; }
        public DbSet<StickyNoteGroup> NoteGroups { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Todo.db");

    }
}
