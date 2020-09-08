using System;
using System.Collections.Generic;
using StickyGO.Models;
using StickyGO.Models.DataAccess;
using StickyGO.Views;

namespace StickyGO.ViewModels
{
    public class MainPageViewModel
    {
        public List<StickyNote> StickyNotes { get; set; }

        public MainPageViewModel()
        {

            DataAccessor.SaveStickyNote(new StickyNote() { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis lobortis tempor dictum. In ultrices pretium metus nec dictum. In sed sagittis est. Quisque dictum suscipit est quis mattis.", Color = "#d32f2f" });
            DataAccessor.SaveStickyNote(new StickyNote() { Text = "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nam mollis ipsum in diam viverra vulputate.", Color = "#1e88e5" });

            StickyNotes = DataAccessor.GetStickyNotes();
        }

        public void CreateNewStickyNote()
        {
            StickyNoteView view = new StickyNoteView(new StickyNote());
            view.Show();
        }
    }
}
