using TaskManagerApi.Models;

namespace TaskManagerApi.Interfaces
{
    public interface ITaskService
    {
        IEnumerable<TaskItem> GetAll();
        TaskItem? GetById(int id);
        TaskItem Add(string title);
        bool Complete(int id);
    }
}
