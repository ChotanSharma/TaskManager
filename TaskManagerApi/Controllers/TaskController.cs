using Microsoft.AspNetCore.Mvc;
using TaskManagerApi.Interfaces;

namespace TaskManagerApi.Controllers
{   //API controller responsible for handling HTTP request
    [ApiController]
    // Base route e.g api/tasks
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        // Service that contains business logic for task operations
        private readonly ITaskService _taskService;
        // Constructor with dependency injection of the task service
        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        // Retrieves all tasks
        // GET: api/tasks
        [HttpGet]
        public IActionResult GetAll()
        {
            // Returns 200 OK with the list of tasks
            return Ok(_taskService.GetAll());
        }

        // Retrieves a task based on id
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var task = _taskService.GetById(id);
            if (task == null) return NotFound();
            // Return 200 OK with the task data
            return Ok(task);
        }

        // Creates a new task
        // POST: api/tasks
        [HttpPost]
        public IActionResult Create([FromBody] string title)
        {
            var task = _taskService.Add(title);
            // Return 201 Created with a Location heade
            return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
        }
        // Marks an existing task as completed
        // PUT: api/tasks/{id}/complete
        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            if (!_taskService.Complete(id))
            return NotFound();
            // Return 204 No Content on successful update
            return NoContent();
        }

    }
}
