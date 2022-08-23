namespace ToDo.List.Data
{
    public interface IToDoDb
    {
        IEnumerable<Models.ToDo> GetToDos();
    }

    public class ToDoDb : IToDoDb
    {
        private readonly IEnumerable<Models.ToDo> toDos = new List<Models.ToDo>();

        public IEnumerable<Models.ToDo> GetToDos()
        {
            return toDos;
        }
    }
}