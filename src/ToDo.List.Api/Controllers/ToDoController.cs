using Microsoft.AspNetCore.Mvc;

namespace ToDo.List.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly IEnumerable<ToDo> _toDos;
        
        public ToDoController()
        {
            _toDos = new List<ToDo>();
        }

        [HttpGet]
        public IEnumerable<ToDo> Get()
        {
            return _toDos;
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }
    }
}