using TaskManagerApi.Models;
// Defines a contract for task-related business logic.
// Any class implementing this interface must provide
// concrete implementations for all declared methods.
namespace TaskManagerApi.Interfaces
{
    public interface ITaskService
    {
         // Retrieves all task items from the data source
        IEnumerable<TaskItem> GetAll();
        // Retrieves a single task by its unique identifier
        // Returns null if the task does not exist
        TaskItem? GetById(int id);
         // Creates a new task with the given title
        TaskItem Add(string title);
        // Marks the specified task as completed
        // Returns true if the task was found and updated, otherwise false
        bool Complete(int id);
    }
}
