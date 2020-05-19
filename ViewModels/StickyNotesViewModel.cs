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
            DataAccessor.SaveStickyNote(new StickyNote() { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis lobortis tempor dictum. In ultrices pretium metus nec dictum. In sed sagittis est. Quisque dictum suscipit est quis mattis.", Group = group });

            StickyNoteGroup group2 = new StickyNoteGroup() { Name = "G2", Color = "Blue" };
            DataAccessor.SaveStickyNoteGroup(group2);
            DataAccessor.SaveStickyNote(new StickyNote() { Text = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nam mollis ipsum in diam viverra vulputate.", Group = group2 });

            StickyNotes = DataAccessor.GetStickyNotes();
        }

    }
}
