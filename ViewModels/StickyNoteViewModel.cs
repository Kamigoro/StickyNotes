using StickyGO.Models;
using StickyGO.Models.DataAccess;
using StickyGO.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace StickyGO.ViewModels
{
    public class StickyNoteViewModel
    {
        public StickyNote StickyNote { get; set; }

        public StickyNoteViewModel()
        {
            StickyNote = new StickyNote();
        }

        public StickyNoteViewModel(StickyNote stickyNote)
        {
            StickyNote = stickyNote;
        }

        public void CreateNewStickyNote()
        {
            StickyNoteView view = new StickyNoteView();
            view.Show();
        }

        public void SaveStickyNote(string text, string color)
        {
            StickyNote stickyNote = new StickyNote() { Text = text, Color = color };
            DataAccessor.SaveStickyNote(stickyNote);
        }
    }
}
