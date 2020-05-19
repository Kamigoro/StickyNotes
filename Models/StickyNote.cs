﻿namespace Todo.Models
{
    public class StickyNote
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public StickyNoteGroup Group { get; set; }

        public override string ToString()
        {
            return $"Name : {Name}\nText : {Text}\nGroup : {Group.Name}";
        }

    }
}