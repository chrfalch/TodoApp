using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoApp.Shared.BL.Models;
using TodoApp.Shared.BL.Tests.TestHelpers;
using TodoApp.Shared.BL.UnitsOfWork;

namespace TodoApp.Shared.BL.Tests
{
    [TestClass]
    public class TodoItemUnitOfWorkTests
    {
        [TestMethod]
        public void We_Get_A_Sorted_List_With_Newest_First_Of_Items_When_Calling_GetSortedItems()
        {
            // Arrange
            var repo = new ListRepository<ITodoItem>();
            repo.Add(new TodoItem(){ Date = new DateTime(2013,1,1) });
            repo.Add(new TodoItem() { Date = new DateTime(2014, 1, 1) });

            var unitOfWork = new TodoItemUnitOfWork(repo);
            
            // Act
            var items = unitOfWork.GetSortedItems().ToList();

            // Assert
            Assert.AreEqual(new DateTime(2014, 1, 1), items.ElementAt(0).Date);
            Assert.AreEqual(new DateTime(2013, 1, 1), items.ElementAt(1).Date);
        }
    }
}
