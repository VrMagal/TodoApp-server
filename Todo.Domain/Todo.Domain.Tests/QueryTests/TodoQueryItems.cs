using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryItems
    {
        private List<TodoItem> _items;

        public TodoQueryItems()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "Victor"));
            _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "Victor"));
            _items.Add(new TodoItem("Tarefa 3", DateTime.Now, "usuario1"));
            _items.Add(new TodoItem("Tarefa 4", DateTime.Now, "usuario1"));
            _items.Add(new TodoItem("Tarefa 5", DateTime.Now, "usuario1"));
            _items.Add(new TodoItem("Tarefa 6", DateTime.Now, "usuario1"));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_apenas_o_usuario_victor()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("Victor"));

            Assert.AreEqual(2, result.Count());
        }
    }
}
