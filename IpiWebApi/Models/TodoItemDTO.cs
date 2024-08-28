namespace IpiWebApi.Models
{
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public static class TodoItemExtensions
    {
        public static TodoItemDTO ToDTO(this TodoItem totoItem)
        {
            return new TodoItemDTO { Id = totoItem.Id, Name = totoItem.Name, IsComplete = totoItem.IsComplete, };
        }

        public static TodoItem ToModel(this TodoItemDTO dto)
        {
            return new TodoItem { Id = dto.Id, Name = dto.Name, IsComplete = dto.IsComplete };
        }
    }
}
