using Microsoft.AspNetCore.Mvc;
using ToDo.List.Api.Repositories;

namespace ToDo.List.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoRepository toDoRepository;

        public ToDoController(IToDoRepository toDoRepository)
        {
            this.toDoRepository = toDoRepository;
        }

        [HttpGet]
        public IEnumerable<Data.Models.ToDo> Get()
        {
            return toDoRepository.GetToDos();
        }

        [HttpPost]
        public IActionResult Post([FromBody]Data.Models.ToDo toDo)
        {
            toDoRepository.AddToDo(toDo);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody]Data.Models.ToDo toDo)
        {
            toDoRepository.UpdateToDo(toDo);

            return Ok();
        }
    }
}