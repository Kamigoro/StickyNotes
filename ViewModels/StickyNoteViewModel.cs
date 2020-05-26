﻿using StickyGO.Models;
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
    }
}
