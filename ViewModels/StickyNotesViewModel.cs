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

            DataAccessor.SaveStickyNote(new StickyNote() { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis lobortis tempor dictum. In ultrices pretium metus nec dictum. In sed sagittis est. Quisque dictum suscipit est quis mattis.", Color = "#d32f2f" });
            DataAccessor.SaveStickyNote(new StickyNote() { Text = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nam mollis ipsum in diam viverra vulputate.", Color = "#1e88e5" });

            StickyNotes = DataAccessor.GetStickyNotes();
        }

    }
}
