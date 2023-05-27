using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntitiesTests
{
    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem _validTodoItem = new TodoItem("teste_title", DateTime.Now, "title_user");
        [TestMethod]
        public void Criando_um_todo_o_done_nao_pode_estar_concluido()
        {
            Assert.AreEqual(_validTodoItem.Done, false);
        }
    }
}
