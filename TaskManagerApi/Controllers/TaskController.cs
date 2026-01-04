using Microsoft.AspNetCore.Mvc;
using TaskManagerApi.Interfaces;

namespace TaskManagerApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_taskService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var task = _taskService.GetById(id);
            if (task == null) return NotFound();

            return Ok(task);
        }

        [HttpPost]
        public IActionResult Create([FromBody] string title)
        {
            var task = _taskService.Add(title);
            return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
        }

        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            if (!_taskService.Complete(id))
            return NotFound();

            return NoContent();
        }

    }
}
