namespace ToDo.List.Data
{
    public interface IToDoDb
    {
        void AddToDo(Models.ToDo toDo);
        IEnumerable<Models.ToDo> GetToDos();
        Models.ToDo GetToDo(Models.ToDo toDo);
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

        public Models.ToDo GetToDo(Models.ToDo toDo)
        {
            return toDos.FirstOrDefault(t => t.Id == toDo.Id);
        }
    }
}