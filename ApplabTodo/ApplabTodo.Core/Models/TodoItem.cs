using System;

namespace ApplabTodo.Core
{
	public class TodoItem 
	{
		long Id { get; set; }
		string Title { get; set; }
		bool IsCompleted { get; set; }
		bool Urgent { get; set; }
		string Deadline { get; set; }
	}
}

