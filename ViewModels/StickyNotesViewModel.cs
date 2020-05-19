using System.Collections.Generic;
using Todo.Models;
using Todo.Models.DataAccess;

namespace Todo.ViewModels
{
    public class StickyNotesViewModel
    {
        public List<StickyNote> StickyNotes { get; set; }

        public StickyNotesViewModel()
        {
            StickyNoteGroup group = new StickyNoteGroup() { Name = "G1", Color = "Red" };
            DataAccessor.SaveStickyNoteGroup(group);
            DataAccessor.SaveStickyNote(new StickyNote() { Name = "Test", Text = "CECI EST UN TEST FDP", Group = group });

            StickyNotes = DataAccessor.GetStickyNotes();
        }

    }
}
