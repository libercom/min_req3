using Microsoft.AspNetCore.Mvc;

namespace Todo
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;

        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var todos = _todoService.GetAll();

            return Ok(todos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var todo = _todoService.GetById(id);

            return Ok(todo);
        }

        [HttpPost]
        public IActionResult Create([FromBody] string title)
        {
            var todo = _todoService.Create(title);

            return Ok(todo);
        }

        [HttpDelete]
        public IActionResult Delete([FromRoute] int id)
        {
            var todo = _todoService.Delete(id);

            return Ok(todo);
        }

        [HttpPatch]
        public IActionResult Update([FromRoute] int id, [FromBody] string title)
        {
            var todo = _todoService.Update(id, title);

            return Ok(todo);
        }
    }
}
