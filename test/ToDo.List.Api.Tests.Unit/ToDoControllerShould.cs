using Microsoft.AspNetCore.Mvc;
using ToDo.List.Api.Controllers;
using ToDo.List.Api.Repositories;

namespace ToDo.List.Api.Tests.Unit
{
    public class ToDoControllerShould
    {
        private readonly ToDoController toDoController;

        public ToDoControllerShould()
        {
            var mockToDoRepository = new Mock<IToDoRepository>();
            mockToDoRepository.Setup(mtdr => mtdr.GetToDos())
                .Returns(new List<Data.Models.ToDo>());

            toDoController = new ToDoController(mockToDoRepository.Object);
        }

        [Fact]
        public void ReturnEnumerableOfToDo_WhenGetCalled()
        {
            var result = toDoController.Get();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<Data.Models.ToDo>>(result);
        }

        [Fact]
        public void ReturnOkResult_WhenPostCalled()
        {
            var result = toDoController.Post();

            Assert.NotNull(result);
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void ReturnOkResult_WhenPutCalled()
        {
            var result = toDoController.Put();

            Assert.NotNull(result);
            Assert.IsType<OkResult>(result);
        }
    }
}