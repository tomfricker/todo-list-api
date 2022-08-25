using ToDo.List.Data;
using ToDo.List.Data.Enums;

namespace ToDo.List.Tests.Unit.TestData
{
    public class ToDoTestFixture : IToDoDb
    {
        private readonly IToDoDb toDoDb;

        public ToDoTestFixture()
        {
            toDoDb = new ToDoDb();

            for (var i = 0; i < 4; i++)
            {
                var toDo = new Data.Models.ToDo { Id = Guid.NewGuid(), Description = $"Task {i}", State = State.Pending };
                toDoDb.AddToDo(toDo);
            }            
        }

        public void AddToDo(Data.Models.ToDo toDo)
        {
            toDoDb.AddToDo(toDo);
        }

        public IEnumerable<Data.Models.ToDo> GetToDos()
        {
            return toDoDb.GetToDos();
        }

        public Data.Models.ToDo GetToDo(Data.Models.ToDo toDo)
        {
            return toDoDb.GetToDo(toDo);
        }
    }
}
