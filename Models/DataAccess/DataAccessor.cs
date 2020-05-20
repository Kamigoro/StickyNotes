using System.Collections.Generic;
using System.Linq;

namespace Todo.Models.DataAccess
{
    /// <summary>
    /// Static class containing CRUD operations to interact with the database.
    /// </summary>
    public static class DataAccessor
    {

        /// <summary>
        /// Get all the sticky notes inside the database.
        /// </summary>
        /// <returns></returns>
        public static List<StickyNote> GetStickyNotes()
        {
            using (var database = new NoteContext())
            {
                return database.Notes.ToList();
            }
        }

        /// <summary>
        /// Saves a sticky note inside the database.
        /// </summary>
        /// <param name="stickyNote"></param>
        /// <returns></returns>
        public static void SaveStickyNote(StickyNote stickyNote)
        {
            using (var database = new NoteContext())
            {
                database.Notes.Add(stickyNote);
                database.SaveChanges();
            }
        }

    }
}
