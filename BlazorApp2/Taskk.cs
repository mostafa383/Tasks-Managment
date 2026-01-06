namespace BlazorApp2
{
    public class Taskk
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public Pirority Pirority { get; set; }
        public TaskType TaskType { get; set; }
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
        public int Position { get; set; }
    }
}
