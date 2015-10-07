using System;
using System.Collections.Generic;
using SQLite.Net;
using SQLiteNetExtensions.Extensions;

namespace Applabtodotesting.Core
{
	public class DataService : IDataService
	{
		SQLiteConnection _conn;
		public DataService (SQLiteConnection connection)
		{
			_conn = connection;
			_conn.CreateTable<TodoItem> ();
		}

		#region IDataService implementation

		public int Create (TodoItem todoItem)
		{
			return _conn.Insert (todoItem);
		}

		public int Delete (int id)
		{
			var todoItem = Get (id);
			return _conn.Delete (todoItem);
		}

		public TodoItem Get (int id)
		{
			return _conn.Get<TodoItem> (id);
		}

		public IEnumerable<TodoItem> GetAll ()
		{
			return _conn.GetAllWithChildren<TodoItem> ();
		}


		public int Update (TodoItem todoItem)
		{
			return _conn.Update (todoItem);
		}
		#endregion
	}
}

