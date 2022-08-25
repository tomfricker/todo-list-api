using ToDo.List.Api.Repositories;
using ToDo.List.Tests.Unit.TestData;

namespace ToDo.List.Api.Tests.Unit
{
    public class ToDoRepositoryShould
    {
        private readonly ToDoRepository toDoRepository;
        private readonly ToDoTestFixture toDoTestFixture;

        public ToDoRepositoryShould()
        {
            toDoTestFixture = new ToDoTestFixture();
            toDoRepository = new ToDoRepository(toDoTestFixture);
        }

        [Fact]
        public void ReturnEnumerableOfToDos_WhenDataExistsinDb()
        {
            var result = toDoRepository.GetToDos();

            Assert.NotNull(result);
            Assert.Equal(4, result.Count());
        }

        [Fact]
        public void AddToDoToDb_WhenAddToDoCalled()
        {
            var toDo = new Data.Models.ToDo();

            toDoRepository.AddToDo(toDo);

            var toDoListResult = toDoTestFixture.GetToDos();

            Assert.Equal(5, toDoListResult.Count());
            Assert.Contains(toDo, toDoListResult);
        }

        [Fact]
        public void AddNewGuidId_WhenAddToDoCalled()
        {
            var toDo = new Data.Models.ToDo();

            toDoRepository.AddToDo(toDo);

            var toDoListResult = toDoTestFixture.GetToDos();

            Assert.DoesNotContain(toDoListResult, t => t.Id == Guid.Empty);
        }

        [Fact]
        public void UpdateToDo_WhenUpdateToDoCalled()
        {
            var toDo = toDoRepository.GetToDos().FirstOrDefault();

            var updatedToDo = new Data.Models.ToDo
            {
                Id = toDo.Id,
                Description = "New Description",
                State = Data.Enums.State.Completed
            };

            toDoRepository.UpdateToDo(updatedToDo);

            Assert.Equal(toDo.Description, updatedToDo.Description);
            Assert.Equal(toDo.State, updatedToDo.State);
        }
    }
}
