namespace Todo
{
    public class TodoService
    {
        private readonly IList<Todo> _todo;

        public TodoService()
        {
            _todo = new List<Todo>();
        }

        public IList<Todo> GetAll()
        {
            return _todo;
        }

        public Todo GetById(int id)
        {
            return _todo.FirstOrDefault(x => x.Id == id);
        }

        public Todo Create(string title)
        {
            var todo = new Todo { Id = _todo.Count(), Title = title };

            _todo.Add(todo);

            return todo;
        }

        public Todo Update(int id, string title)
        {
            _todo[id].Title = title;

            return _todo[id];
        }

        public Todo Delete(int id)
        {
            var todo = _todo[id];

            _todo.RemoveAt(id);

            return todo;
        }
    }
}
