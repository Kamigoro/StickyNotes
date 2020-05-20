namespace Todo.Models
{
    public class StickyNote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Text : {Text}";
        }

    }
}
