using System;
using System.Linq;
using Applabtodotesting.Core;
using System.Collections.Generic;

namespace Applabtoditesting.Tests
{
	public class FakeDataService : IDataService
	{
		private Dictionary<int, TodoItem> _todoItems;
		private int _idIterator = 0;
		public FakeDataService ()
		{
			_todoItems = new Dictionary<int, TodoItem> ();
		}

		#region IDataService implementation

		public int Create (TodoItem todoItem)
		{
			_todoItems.Add (_idIterator, todoItem);
			_idIterator++;
			return _idIterator;
		}

		public int Delete (int id)
		{
			_todoItems.Remove (id);
			return id;
		}

		public TodoItem Get (int id)
		{
			return _todoItems [id];
		}

		public int Update (TodoItem todoItem)
		{
			_todoItems [todoItem.Id] = todoItem;
			return todoItem.Id;
		}

		public System.Collections.Generic.IEnumerable<TodoItem> GetAll ()
		{
			return _todoItems.Select (t => t.Value);
		}

		#endregion
	}
}

