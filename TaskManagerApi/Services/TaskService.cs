using TaskManagerApi.Interfaces;
using TaskManagerApi.Models;

namespace TaskManagerApi.Services
{
    public class TaskService :ITaskService
    {
        private readonly List<TaskItem> _tasks = new();
        private int _nextId = 1;
        
        public IEnumerable<TaskItem> GetAll()
        {
            return _tasks;
        }

        public TaskItem? GetById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }

        public TaskItem Add(string title)
        {
            var task = new TaskItem
            {
                Id = _nextId++,
                Title = title,
                IsCompleted = false
            };

            _tasks.Add(task);
            return task;
        }

        public bool Complete(int id)
        {
            var task = GetById(id);
            if (task == null) return false;

            task.IsCompleted = true;
            return true;
        }

    }
}
