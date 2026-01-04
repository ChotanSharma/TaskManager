using TaskManagerApi.Interfaces;
using TaskManagerApi.Models;

namespace TaskManagerApi.Services
{
    // Concrete implementation of the ITaskService interface.
    public class TaskService :ITaskService
    {
        // In-memory list to store tasks (acts as a temporary data store)
        private readonly List<TaskItem> _tasks = new();
        // Track the task with the initialization
        private int _nextId = 1;
        // Returns all tasks
        public IEnumerable<TaskItem> GetAll()
        {
            return _tasks;
        }
        // Returns task by specific id
        public TaskItem? GetById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }
        // Creating new task
        // returns the new task

        public TaskItem Add(string title)
        {
            var task = new TaskItem
            {
                Id = _nextId++,
                Title = title,
                IsCompleted = false
            };
             // Add the new task to the in-memory list
            _tasks.Add(task);
            // returns new task
            return task;
        }
        // Marks the task with the specified ID as completed
        // Returns false if the task does not exist
        public bool Complete(int id)
        {
            // Retrieve the task by ID
            var task = GetById(id);
            // Check if task exist
            if (task == null) return false;
            // mark it as completed if exist
            task.IsCompleted = true;
            return true;
        }

    }
}
