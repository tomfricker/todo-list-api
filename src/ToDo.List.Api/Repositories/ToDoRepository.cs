using ToDo.List.Data;

namespace ToDo.List.Api.Repositories
{
    public interface IToDoRepository
    {
        IEnumerable<Data.Models.ToDo> GetToDos();
        void AddToDo(Data.Models.ToDo toDo);
    }

    public class ToDoRepository : IToDoRepository
    {
        private readonly IToDoDb toDoDb;

        public ToDoRepository(IToDoDb toDoDb)
        {
            this.toDoDb = toDoDb;
        }

        public void AddToDo(Data.Models.ToDo toDo)
        {
            toDo.Id = Guid.NewGuid();

            toDoDb.AddToDo(toDo);
        }

        public IEnumerable<Data.Models.ToDo> GetToDos()
        {
            return toDoDb.GetToDos();
        }
    }
}
