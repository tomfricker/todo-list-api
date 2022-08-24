using ToDo.List.Data;
using ToDo.List.Data.Enums;

namespace ToDo.List.Tests.Unit.TestData
{
    public class ToDoTestFixture : IToDoDb
    {
        private IList<Data.Models.ToDo> toDos;

        public ToDoTestFixture()
        {
            toDos = new List<Data.Models.ToDo>
            {
                new Data.Models.ToDo { Id = Guid.NewGuid(), Description = "Task 1", State = State.Pending },
                new Data.Models.ToDo { Id = Guid.NewGuid(), Description = "Task 2", State = State.Pending },
                new Data.Models.ToDo { Id = Guid.NewGuid(), Description = "Task 3", State = State.Pending },
                new Data.Models.ToDo { Id = Guid.NewGuid(), Description = "Task 4", State = State.Completed }
            };
        }

        public void AddToDo(Data.Models.ToDo toDo)
        {
            toDos.Add(toDo);
        }

        public IEnumerable<Data.Models.ToDo> GetToDos()
        {
            return toDos;
        }
    }
}
