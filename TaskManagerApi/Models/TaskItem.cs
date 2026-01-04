namespace TaskManagerApi.Models
{
    // TaskTtem class with three attributes
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
    }
}
