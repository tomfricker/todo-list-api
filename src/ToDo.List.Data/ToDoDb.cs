namespace ToDo.List.Data
{
    public interface IToDoDb
    {
        void AddToDo(Data.Models.ToDo toDo);
        IEnumerable<Models.ToDo> GetToDos();
    }

    public class ToDoDb : IToDoDb
    {
        private readonly IList<Models.ToDo> toDos = new List<Models.ToDo>();

        public void AddToDo(Models.ToDo toDo)
        {
            toDos.Add(toDo);
        }

        public IEnumerable<Models.ToDo> GetToDos()
        {
            return toDos;
        }
    }
}