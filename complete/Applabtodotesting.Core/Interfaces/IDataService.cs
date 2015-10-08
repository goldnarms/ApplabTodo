using System;
using System.Collections.Generic;

namespace Applabtodotesting.Core
{
	public interface IDataService
	{
		int Create(TodoItem todoItem);
		int Delete(int id);
		TodoItem Get(int id);
		int Update (TodoItem todoItem);
		IEnumerable<TodoItem> GetAll ();
	}
}

