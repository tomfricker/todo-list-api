namespace ToDo.List.Api.Repositories
{
    public interface IToDoRepository
    {
        IEnumerable<Data.Models.ToDo> GetToDos();
    }

    public class ToDoRepository : IToDoRepository
    {
        public IEnumerable<Data.Models.ToDo> GetToDos()
        {
            throw new NotImplementedException();
        }
    }
}
