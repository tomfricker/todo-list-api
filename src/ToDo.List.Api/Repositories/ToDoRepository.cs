using ToDo.List.Data;

namespace ToDo.List.Api.Repositories
{
    public interface IToDoRepository
    {
        void AddToDo(Data.Models.ToDo toDo);
        IEnumerable<Data.Models.ToDo> GetToDos();
        void UpdateToDo(Data.Models.ToDo toDo);
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

        public void UpdateToDo(Data.Models.ToDo toDo)
        {
            var toDoToUpdate = toDoDb.GetToDo(toDo);

            if (toDoToUpdate != null)
            {
                toDoToUpdate.State = toDo.State;
                toDoToUpdate.Description = toDo.Description;
            }
        }
    }
}
