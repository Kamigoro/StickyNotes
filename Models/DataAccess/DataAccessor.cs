using Microsoft.EntityFrameworkCore;
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
                return database.Notes.
                    Include(note => note.Group).
                    ToList();
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
                database.NoteGroups.Attach(stickyNote.Group);//This line of code is there to stop EF from duplicating the group in the database and cousing an error
                database.Notes.Add(stickyNote);
                database.SaveChanges();
            }
        }

        /// <summary>
        /// Get all the sticky note groups inside the database.
        /// </summary>
        /// <returns></returns>
        public static List<StickyNoteGroup> GetStickyNoteGroups()
        {
            using (var database = new NoteContext())
            {
                return database.NoteGroups.ToList();
            }
        }

        /// <summary>
        /// Saves a sticky note group inside the database.
        /// </summary>
        /// <param name="stickyNoteGroup"></param>
        /// <returns></returns>
        public static void SaveStickyNoteGroup(StickyNoteGroup stickyNoteGroup)
        {
            using (var database = new NoteContext())
            {
                database.NoteGroups.Add(stickyNoteGroup);
                database.SaveChanges();
            }
        }

    }
}
