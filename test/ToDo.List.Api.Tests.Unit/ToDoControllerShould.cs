using Microsoft.AspNetCore.Mvc;
using ToDo.List.Api.Controllers;

namespace ToDo.List.Api.Tests.Unit
{
    public class ToDoControllerShould
    {
        private readonly ToDoController toDoController = new ToDoController();

        [Fact]
        public void ReturnEnumerableOfToDo_WhenGetCalled()
        {
            var result = toDoController.Get();

            Assert.NotNull(result);
            Assert.IsAssignableFrom<IEnumerable<ToDo>>(result);
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