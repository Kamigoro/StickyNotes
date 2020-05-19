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
            StickyNotes = DataAccessor.GetStickyNotes();
        }

    }
}
