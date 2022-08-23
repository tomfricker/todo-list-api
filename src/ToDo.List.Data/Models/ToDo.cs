using ToDo.List.Data.Enums;

namespace ToDo.List.Data.Models
{
    public class ToDo
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public State State { get; set; }
    }
}