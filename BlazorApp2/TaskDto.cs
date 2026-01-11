namespace BlazorApp2
{
    public class TaskDto
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public Pirority Pirority { get; set; }
        public TaskType TaskType { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; }
        public int Position { get; set; }
    }
}
