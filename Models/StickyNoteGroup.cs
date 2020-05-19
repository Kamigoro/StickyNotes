namespace Todo.Models
{
    public class StickyNoteGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Name : {Name}\nColor : {Color}";
        }
    }
}
